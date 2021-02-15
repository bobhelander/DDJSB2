using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDJSB2.Controls;

namespace DDJSB2.Layout
{
    public static class Encoders
    {
        // Deck Channel
        public static Encoder JogDialEncoder => new Encoder { Name = "Jog Dial", NoteNumber = 0x35, ControlNumber = 0x23, Cutoff = 0x40 };
        public static Encoder JogDialShiftedEncoder => new Encoder { Name = "Jog Dial Shifted", NoteNumber = 0x67, ControlNumber = 0x1F, Cutoff = 0x40 };

        // Channel 7
        public static Encoder BrowseEncoder => new Encoder { Name = "Browse", NoteNumber = 0x41, ControlNumber = 0x40, Cutoff = 0x00 };
        public static Encoder BrowseShiftedEncoder => new Encoder { Name = "Browse Shifter", NoteNumber = 0x42, ControlNumber = 0x64, Cutoff = 0x00 };
    }
}
