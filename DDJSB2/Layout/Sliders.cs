using DDJSB2.Controls;
using DDJSB2.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2.Layout
{
    public static class Sliders
    {
        // Deck Channel
        public static Slider TempoSlider => new Slider { 
            Name = "Tempo",
            Controls = new IControlChange[] {
                (IControlChange) new ControlChange { ControlName = "HighControl", ControlNumber = 0x00 },
                (IControlChange) new ControlChange { ControlName = "LowControl", ControlNumber = 0x20 } }
        };

        public static Slider TempoShiftedSlider => new Slider
        {
            Name = "Tempo (Shifted)",
            Controls = new IControlChange[] {
                (IControlChange) new ControlChange { ControlName = "HighControl", ControlNumber = 0x05 },
                (IControlChange) new ControlChange { ControlName = "LowControl", ControlNumber = 0x25 } }
        };

        public static Slider ChannelFaderSlider => new Slider { 
            Name = "Channel Fader",
            Controls = new IControlChange[] {
                (IControlChange) new ControlChange { ControlName = "HighControl", ControlNumber = 0x13 },
                (IControlChange) new ControlChange { ControlName = "LowControl", ControlNumber = 0x33 } }
        };

        // Middle Channel 7
        public static Slider CrossFaderSlider => new Slider { 
            Name = "Cross Fader",
            Controls = new IControlChange[] {
                (IControlChange) new ControlChange { ControlName = "HighControl", ControlNumber = 0x1F },
                (IControlChange) new ControlChange { ControlName = "LowControl", ControlNumber = 0x3F } }
        };
    }
}
