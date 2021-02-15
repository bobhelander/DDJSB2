using DDJSB2.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2.Controls
{
    public class Encoder : Common.ControlBase<State>, INoteControl, INoteChangeHandler, IControlChange, IControl
    {
        public string Name { get; set; }
        //public byte Dial { get; set; }

        // Touch
        public byte NoteNumber { get; set; }
        public byte NoteValue { get; set; }

        // Jog
        public string ControlName { get; set; }
        public byte ControlNumber { get; set; }
        public byte ControlValue { get; set; }

        public byte Cutoff { get; set; } // 0x40:  (0x41 >= Clockwise) (0x3F <= CounterClockwise)
                                         // 0x00:  (0x01 >= Clockwise) (0x7F <= CounterClockwise)

        public bool ProcessNoteEvent(int channel, byte noteNumber, byte noteValue)
        {
            if (noteNumber == NoteNumber)
            {
                NoteValue = noteValue;
                Notify(new State { Control = this, Channel = channel, Number = noteNumber, Value = noteValue });
                return true;
            }

            return false;
        }

        public bool ProcessControlChangeEvent(int channel, byte controlNumber, byte controlValue)
        {
            if (ControlNumber == controlNumber)
            {
                ControlValue = controlValue;
                Notify(new State { Control = this, Channel = channel, Number = controlNumber, Value = controlValue });
                return true;
            }

            return false;
        }
    }
}
