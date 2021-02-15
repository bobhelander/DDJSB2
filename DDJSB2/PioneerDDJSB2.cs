using DDJSB2.Controls;
using DDJSB2.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2
{
    public class PioneerDDJSB2 : IDisposable
    {
        public static PioneerDDJSB2 CreateInstance => DDJSB2.Layout.Factory.CreateInstance();

        private const string PRODUCT_NAME = "DDJ-SB2 MIDI";

        public Dictionary<int, List<IControl>> ChannelControls { get; set; }
        public NAudio.Midi.MidiIn MidiIn { get; set; }
        public NAudio.Midi.MidiOut MidiOut { get; set; }

        public void Initialize()
        {
            MidiOut = new NAudio.Midi.MidiOut(FindOutDeviceNumber());
            MidiIn = new NAudio.Midi.MidiIn(FindInDeviceNumber());

            MidiIn.MessageReceived += MessageReceived;
            MidiIn.ErrorReceived += ErrorReceived;

            MidiIn?.Reset();
            MidiIn?.Start();

            // Send all positions
            MidiOut?.SendBuffer(new byte[] { 0x9B, 0x09, 0x7f });
        }

        public void LedControl(Leds.Deck deck, Led led, bool shift, bool on)
        {
            byte channel = (byte)(led.baseChannel + deck);
            byte button = shift ? led.shiftedLedButton : led.ledButton;
            byte value = on ? Leds.on : Leds.off;

            MidiOut?.SendBuffer(new byte[] { channel, button, value });
        }

        public void PadLedControl(Leds.Deck deck, Leds.PadGroup padGroup, Led led, bool shift, bool on)
        {
            byte channel = (byte)(led.baseChannel + deck);
            byte button = (byte)((shift ? led.shiftedLedButton : led.ledButton) + padGroup);
            byte value = on ? Leds.on : Leds.off;

            MidiOut?.SendBuffer(new byte[] { channel, button, value });
        }

        public void LevelLedControl(Leds.Deck deck, LevelLed led, byte value)
        {
            byte channel = (byte)(led.baseChannel + deck);
            byte button = led.ledButton;

            MidiOut?.SendBuffer(new byte[] { channel, button, value });
        }

        private void ErrorReceived(object sender, NAudio.Midi.MidiInMessageEventArgs e)
        {
            Console.WriteLine($"Midi Error: {e.MidiEvent}: {e.RawMessage}");
        }

        private void MessageReceived(object sender, NAudio.Midi.MidiInMessageEventArgs e)
        {
            if (e.MidiEvent is NAudio.Midi.NoteEvent)
            {
                var noteEvent = e.MidiEvent as NAudio.Midi.NoteEvent;
                Console.WriteLine($"Midi Note: {noteEvent.NoteNumber:X2}: {noteEvent}");

                NoteEvent(noteEvent.Channel, (byte)noteEvent.NoteNumber, (byte)noteEvent.Velocity);
            }
            else if (e.MidiEvent is NAudio.Midi.ControlChangeEvent)
            {
                var controlChangeEvent = e.MidiEvent as NAudio.Midi.ControlChangeEvent;
                Console.WriteLine($"ControlChangeEvent: {(byte)controlChangeEvent.Controller:X2}: {controlChangeEvent}");

                var controlNumber = (byte)controlChangeEvent.Controller;
                var channelNumber = controlChangeEvent.Channel;
                var value = controlChangeEvent.ControllerValue;

                ControlChangeEvent(channelNumber, controlNumber, (byte)value);
            }
            else
            {
                Console.WriteLine($"Midi: {e.MidiEvent}: {e.RawMessage}");
            }
        }

        public void ControlChangeEvent(int channel, byte controlNumber, byte value)
        {
            if (ChannelControls.ContainsKey(channel))
            {
                foreach(var control in ChannelControls[channel])
                {
                    if (control is IControlChangeHandler)
                    {
                        var controlChange = control as IControlChangeHandler;
                        if (controlChange.ProcessControlChangeEvent(channel, controlNumber, value))
                        {
                            return;
                        }
                    }
                }
            }
        }

        public void NoteEvent(int channel, byte noteNumber, byte value)
        {
            if (ChannelControls.ContainsKey(channel))
            {
                foreach (var control in ChannelControls[channel])
                {
                    if (control is INoteChangeHandler)
                    {
                        var noteControl = control as INoteChangeHandler;
                        if (noteControl.ProcessNoteEvent(channel, noteNumber, value))
                        {
                            return;
                        }
                    }
                }
            }
        }

        private static int FindOutDeviceNumber()
        {
            var count = NAudio.Midi.MidiOut.NumberOfDevices;
            for(int x=0; x < count; x++)
            {
                if (NAudio.Midi.MidiOut.DeviceInfo(x).ProductName == PRODUCT_NAME)
                    return x;
            }

            throw new Exception("Unable to find MIDI output device");
        }

        private static int FindInDeviceNumber()
        {
            var count = NAudio.Midi.MidiIn.NumberOfDevices;
            for (int x = 0; x < count; x++)
            {
                if (NAudio.Midi.MidiIn.DeviceInfo(x).ProductName == PRODUCT_NAME)
                    return x;
            }

            throw new Exception("Unable to find MIDI input device");
        }

        public void Dispose()
        {
            MidiIn?.Close();
            MidiIn?.Dispose();
            MidiOut?.Close();
            MidiOut?.Dispose();
        }
    }
}
