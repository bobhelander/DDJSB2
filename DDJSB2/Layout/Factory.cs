using DDJSB2.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2.Layout
{
    static public class Factory
    {
        static public PioneerDDJSB2 CreateInstance()
        {
            return new PioneerDDJSB2
            {
                ChannelControls = new Dictionary<int, List<IControl>>
                {
                    { 1, CreateDeck() },
                    { 2, CreateDeck() },
                    { 3, CreateDeck() },
                    { 4, CreateDeck() },
                    { 5, CreateEffect() },
                    { 6, CreateEffect() },
                    { 7, CreateCenter() }
                }
            };
        }

        static private List<IControl> CreateDeck()
        {
            return new List<IControl>
            {
                // Add Dials
                Dials.TrimDial,
                Dials.HiDial,
                Dials.MidDial,
                Dials.LowDial,
                Dials.FilterDial,

                // Add Sliders
                Sliders.TempoSlider,
                Sliders.TempoShiftedSlider,
                Sliders.ChannelFaderSlider,

                // Buttons
                Buttons.HeadphoneCueButton,
                Buttons.HeadphoneCueShiftedButton,
                Buttons.KeyLockButton,
                Buttons.KeyLockShiftedButton,
                Buttons.DeckButton,
                Buttons.DeckShiftedButton,
                Buttons.VinylButton,
                Buttons.VinylShiftedButton,
                Buttons.PadTransButton,
                Buttons.PadTransShiftedButton,
                Buttons.PlayButton,
                Buttons.PlayShiftedButton,
                Buttons.CueButton,
                Buttons.CueShiftedButton,
                Buttons.SyncButton,
                Buttons.SyncShiftedButton,
                Buttons.ShiftButton,
                Buttons.HotQueButton,
                Buttons.HotQueShiftedButton,
                Buttons.AutoLoopButton,
                Buttons.AutoLoopShiftedButton,
                Buttons.ManualLoopButton,
                Buttons.ManualLoopShiftedButton,
                Buttons.SamplerButton,
                Buttons.SamplerShiftedButton,
                Buttons.HotQueInButton,
                Buttons.HotQueInShiftedButton,
                Buttons.HotQueOutButton,
                Buttons.HotQueOutShiftedButton,
                Buttons.HotQueExitButton,
                Buttons.HotQueExitShiftedButton,
                Buttons.HotQue2XButton,
                Buttons.HotQue2XShiftedButton,
                Buttons.AutoLoopInButton,
                Buttons.AutoLoopInShiftedButton,
                Buttons.AutoLoopOutButton,
                Buttons.AutoLoopOutShiftedButton,
                Buttons.AutoLoopExitButton,
                Buttons.AutoLoopExitShiftedButton,
                Buttons.AutoLoop2XButton,
                Buttons.AutoLoop2XShiftedButton,
                Buttons.ManualLoopInButton,
                Buttons.ManualLoopInShiftedButton,
                Buttons.ManualLoopOutButton,
                Buttons.ManualLoopOutShiftedButton,
                Buttons.ManualLoopExitButton,
                Buttons.ManualLoopExitShiftedButton,
                Buttons.ManualLoop2XButton,
                Buttons.ManualLoop2XShiftedButton,
                Buttons.SamplerInButton,
                Buttons.SamplerInShiftedButton,
                Buttons.SamplerOutButton,
                Buttons.SamplerOutShiftedButton,
                Buttons.SamplerExitButton,
                Buttons.SamplerExitShiftedButton,
                Buttons.Sampler2XButton,
                Buttons.Sampler2XShiftedButton,
            };
        }

        static private List<IControl> CreateEffect()
        {
            return new List<IControl>
            {
                // Add Dials
                Dials.EffectDial,
                // Add Buttons
                Buttons.Fx1Button,
                Buttons.Fx2Button,
                Buttons.Fx3Button,
                Buttons.Fx1ShiftedButton,
                Buttons.Fx2ShiftedButton,
                Buttons.Fx3ShiftedButton,
            };
        }

        static private List<IControl> CreateCenter()
        {
            return new List<IControl>
            {
                // Add Slider
                Sliders.CrossFaderSlider,
                // Add Dials
                Dials.HeadphonesMixDial,
                // Add Encoder
                Encoders.BrowseEncoder,
                Encoders.BrowseShiftedEncoder,
                // Add Buttons
                Buttons.LoadLeftButton,
                Buttons.LoadLeftShiftedButton,
                Buttons.LoadRightButton,
                Buttons.LoadRightShiftedButton,
            };
        }
    }
}
