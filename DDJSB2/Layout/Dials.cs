using DDJSB2.Controls;
using DDJSB2.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2.Layout
{
    public static class Dials
    {
        // FX Channel 5/6
        public static Dial EffectDial => new Dial
        {
            Name = "Effect Dial (Beats)",
            Controls = new IControlChange[] {
                (IControlChange)new ControlChange { ControlName = "HighControl", ControlNumber = 0x06 },
                (IControlChange)new ControlChange { ControlName = "LowControl", ControlNumber = 0x26 } }
        };
            
        // Deck Channel
        public static Dial TrimDial => new Dial { 
            Name = "Trim", 
            Controls = new IControlChange[] {
                (IControlChange)new ControlChange { ControlName = "HighControl", ControlNumber = 0x04 },
                (IControlChange)new ControlChange { ControlName = "LowControl", ControlNumber = 0x24 } }
        };

        public static Dial HiDial => new Dial { Name = "Hi",
            Controls = new IControlChange[] {
                (IControlChange)new ControlChange { ControlName = "HighControl", ControlNumber = 0x07 },
                (IControlChange)new ControlChange { ControlName = "LowControl", ControlNumber = 0x27 } }
        };

        public static Dial MidDial => new Dial { Name = "Mid",
            Controls = new IControlChange[] {
                (IControlChange)new ControlChange { ControlName = "HighControl", ControlNumber = 0x0B },
                (IControlChange)new ControlChange { ControlName = "LowControl", ControlNumber = 0x2B } }
        };
        public static Dial LowDial => new Dial { Name = "Low",
            Controls = new IControlChange[] {
                (IControlChange)new ControlChange { ControlName = "HighControl", ControlNumber = 0x0F },
                (IControlChange)new ControlChange { ControlName = "LowControl", ControlNumber = 0x2F } }
        };

        public static Dial FilterDial => new Dial { Name = "Filter",
            Controls = new IControlChange[] {
                (IControlChange)new ControlChange { ControlName = "HighControl", ControlNumber = 0x17 },
                (IControlChange)new ControlChange { ControlName = "LowControl", ControlNumber = 0x37 } }
        };

        // Middle Channel 7
        public static Dial HeadphonesMixDial => new Dial { Name = "Headphones Mix",
            Controls = new IControlChange[] {
                (IControlChange)new ControlChange { ControlName = "HighControl", ControlNumber = 0x05 },
                (IControlChange)new ControlChange { ControlName = "LowControl", ControlNumber = 0x25 } }
        };
    }
}
