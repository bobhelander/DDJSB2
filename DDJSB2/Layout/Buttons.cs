using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDJSB2.Controls;

namespace DDJSB2.Layout
{
    public static class Buttons
    {
        // Effects
        public static Button Fx1Button => new Button { Name = "FX1", NoteNumber = 0x47 };
        public static Button Fx2Button => new Button { Name = "FX2", NoteNumber = 0x48 };
        public static Button Fx3Button => new Button { Name = "FX3", NoteNumber = 0x49 };

        public static Button Fx1ShiftedButton => new Button { Name = "FX1 Shifted", NoteNumber = 0x63 };
        public static Button Fx2ShiftedButton => new Button { Name = "FX2 Shifted", NoteNumber = 0x64 };
        public static Button Fx3ShiftedButton => new Button { Name = "FX3 Shifted", NoteNumber = 0x65 };

        // Center
        public static Button LoadLeftButton => new Button { Name = "Left Load", NoteNumber = 0x46 };
        public static Button LoadRightButton => new Button { Name = "Right Load", NoteNumber = 0x47 };
        public static Button LoadLeftShiftedButton => new Button { Name = "Left Load Shifted", NoteNumber = 0x58 };
        public static Button LoadRightShiftedButton => new Button { Name = "Right Load Shifted", NoteNumber = 0x59 };

        // Deck Buttons

        // Slider Special Mode
        public static Button ChannelFaderShifted => new Button { Name = "Channel Fader Shifted", NoteNumber = 0x52 };

        // Buttons
        public static Button HeadphoneCueButton => new Button { Name = "Headphone Cue", NoteNumber = 0x54 };
        public static Button HeadphoneCueShiftedButton => new Button { Name = "Headphone Cue Shifted", NoteNumber = 0x68 };

        public static Button KeyLockButton => new Button { Name = "Key Lock", NoteNumber = 0x1A };
        public static Button KeyLockShiftedButton => new Button { Name = "Key Lock Shifted", NoteNumber = 0x60 };

        public static Button DeckButton => new Button { Name = "Deck", NoteNumber = 0x72 };
        public static Button DeckShiftedButton => new Button { Name = "Deck Shifted", NoteNumber = 0x73 };

        public static Button VinylButton => new Button { Name = "Vinyl", NoteNumber = 0x17 };
        public static Button VinylShiftedButton => new Button { Name = "Vinyl Shifted", NoteNumber = 0x4E };

        public static Button PadTransButton => new Button { Name = "Pad Trans", NoteNumber = 0x70 };
        public static Button PadTransShiftedButton => new Button { Name = "Pad Trans Shifted", NoteNumber = 0x75 };

        public static Button PlayButton => new Button { Name = "Play", NoteNumber = 0x0B };
        public static Button PlayShiftedButton => new Button { Name = "Play Shifted", NoteNumber = 0x47 };

        public static Button CueButton => new Button { Name = "Cue", NoteNumber = 0x0C };
        public static Button CueShiftedButton => new Button { Name = "Cue Shifted", NoteNumber = 0x48 };

        public static Button SyncButton => new Button { Name = "Sync", NoteNumber = 0x58 };
        public static Button SyncShiftedButton => new Button { Name = "Sync Shifted", NoteNumber = 0x5C };

        public static Button ShiftButton => new Button { Name = "Shift", NoteNumber = 0x3F };

        public static Button HotQueButton => new Button { Name = "Hot Que", NoteNumber = 0x1B };
        public static Button HotQueShiftedButton => new Button { Name = "HotQue Shifted", NoteNumber = 0x69 };

        public static Button AutoLoopButton => new Button { Name = "Auto Loop", NoteNumber = 0x1E };
        public static Button AutoLoopShiftedButton => new Button { Name = "Auto Loop Shifted", NoteNumber = 0x6B };

        public static Button ManualLoopButton => new Button { Name = "Manual Loop", NoteNumber = 0x20 };
        public static Button ManualLoopShiftedButton => new Button { Name = "Manual Loop Shifted", NoteNumber = 0x6D };

        public static Button SamplerButton => new Button { Name = "Sampler", NoteNumber = 0x22 };
        public static Button SamplerShiftedButton => new Button { Name = "Sampler Shifted", NoteNumber = 0x6F };

        // Pad Buttons (Hot Que)
        public static Button HotQueInButton => new Button { Name = "In (Hot Que)", NoteNumber = 0x00 };
        public static Button HotQueInShiftedButton => new Button { Name = "In (Hot Que) Shifted", NoteNumber = 0x08 };

        public static Button HotQueOutButton => new Button { Name = "Out (Hot Que)", NoteNumber = 0x01 };
        public static Button HotQueOutShiftedButton => new Button { Name = "Out (Hot Que) Shifted", NoteNumber = 0x09 };

        public static Button HotQueExitButton => new Button { Name = "Exit (Hot Que)", NoteNumber = 0x02 };
        public static Button HotQueExitShiftedButton => new Button { Name = "Exit (Hot Que) Shifted", NoteNumber = 0x0A };

        public static Button HotQue2XButton => new Button { Name = "1/2X (Hot Que)", NoteNumber = 0x03 };
        public static Button HotQue2XShiftedButton => new Button { Name = "1/2X (Hot Que) Shifted", NoteNumber = 0x0B };

        // Pad Buttons (Auto Loop)
        public static Button AutoLoopInButton => new Button { Name = "In (Auto Loop)", NoteNumber = 0x10 };
        public static Button AutoLoopInShiftedButton => new Button { Name = "In (Auto Loop) Shifted", NoteNumber = 0x18 };

        public static Button AutoLoopOutButton => new Button { Name = "Out (Auto Loop)", NoteNumber = 0x11 };
        public static Button AutoLoopOutShiftedButton => new Button { Name = "Out (Auto Loop) Shifted", NoteNumber = 0x19 };

        public static Button AutoLoopExitButton => new Button { Name = "Exit (Auto Loop)", NoteNumber = 0x12 };
        public static Button AutoLoopExitShiftedButton => new Button { Name = "Exit (Auto Loop) Shifted", NoteNumber = 0x1A };

        public static Button AutoLoop2XButton => new Button { Name = "1/2X (Auto Loop)", NoteNumber = 0x13 };
        public static Button AutoLoop2XShiftedButton => new Button { Name = "1/2X (Auto Loop) Shifted", NoteNumber = 0x1B };

        // Pad Buttons (Manual Loop)
        public static Button ManualLoopInButton => new Button { Name = "In (Manual Loop)", NoteNumber = 0x20 };
        public static Button ManualLoopInShiftedButton => new Button { Name = "In (Manual Loop) Shifted", NoteNumber = 0x28 };

        public static Button ManualLoopOutButton => new Button { Name = "Out (Manual Loop)", NoteNumber = 0x21 };
        public static Button ManualLoopOutShiftedButton => new Button { Name = "Out (Manual Loop) Shifted", NoteNumber = 0x29 };

        public static Button ManualLoopExitButton => new Button { Name = "Exit (Manual Loop)", NoteNumber = 0x22 };
        public static Button ManualLoopExitShiftedButton => new Button { Name = "Exit (Manual Loop) Shifted", NoteNumber = 0x2A };

        public static Button ManualLoop2XButton => new Button { Name = "1/2X (Manual Loop)", NoteNumber = 0x23 };
        public static Button ManualLoop2XShiftedButton => new Button { Name = "1/2X (Manual Loop) Shifted", NoteNumber = 0x2B };

        // Pad Buttons (Sampler)
        public static Button SamplerInButton => new Button { Name = "In (Sampler)", NoteNumber = 0x30 };
        public static Button SamplerInShiftedButton => new Button { Name = "In (Sampler) Shifted", NoteNumber = 0x38 };

        public static Button SamplerOutButton => new Button { Name = "Out (Sampler)", NoteNumber = 0x31 };
        public static Button SamplerOutShiftedButton => new Button { Name = "Out (Sampler) Shifted", NoteNumber = 0x39 };

        public static Button SamplerExitButton => new Button { Name = "Exit (Sampler)", NoteNumber = 0x32 };
        public static Button SamplerExitShiftedButton => new Button { Name = "Exit (Sampler) Shifted", NoteNumber = 0x3A };

        public static Button Sampler2XButton => new Button { Name = "1/2X (Sampler)", NoteNumber = 0x33 };
        public static Button Sampler2XShiftedButton => new Button { Name = "1/2X (Sampler) Shifted", NoteNumber = 0x3B };
    }
}
