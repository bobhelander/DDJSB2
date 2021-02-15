using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2
{
    public static class Leds
    {
        public static byte on = 0x7F;
        public static byte off = 0x00;

        public static byte deck1Channel = 0x00;
        public static byte deck2Channel = 0x01;
        public static byte deck3Channel = 0x02;
        public static byte deck4Channel = 0x03;

        public static byte nonPadLedsBaseChannel = 0x90;
        public static byte padLedsBaseChannel = 0x97;
        public static byte fxLedsBaseChannel = 0x94;

        public static byte channelLevelLedsBaseChannel = 0xB0;
        public static byte channelLevelLeds = 0x02;

        public static byte controlChangeBaseChannel = 0xB0;

        public static byte[] hotCue     = { nonPadLedsBaseChannel, 0x00 };
        public static byte[] autoLoop   = { nonPadLedsBaseChannel, 0x10 };
        public static byte[] manualLoop = { nonPadLedsBaseChannel, 0x20 };
        public static byte[] sampler    = { nonPadLedsBaseChannel, 0x30 };

        public enum Deck
        {
            Deck1 = 0x00,
            Deck2 = 0x01,
            Deck3 = 0x02,
            Deck4 = 0x03
        };

        public enum PadGroup : byte
        {
            hotCue = 0x00,
            autoLoop = 0x10,
            manualLoop = 0x20,
            sampler = 0x30,
        };

        public enum ledPadGroupButtons : byte
        {
            hotCue = 0x1B,
            shiftHotCue = 0x69,
            autoLoop = 0x1E,
            shiftAutoLoop = 0x6B,
            manualLoop = 0x20,
            shiftManualLoop = 0x6D,
            sampler = 0x22,
            shiftSampler = 0x6F,
        };

        public enum ledPadButtons : byte
        {
            buttonIn = 0x00,
            buttonOut = 0x01,
            buttonExit = 0x02,
            button2x = 0x03,
        };

        public static Led HeadphoneCueLed = new Led { name = "Headphone Cue", baseChannel = nonPadLedsBaseChannel, ledButton = 0x54, shiftedLedButton = 0x68 };
        public static Led CueLed = new Led { name = "Cue", baseChannel = nonPadLedsBaseChannel, ledButton = 0x0C, shiftedLedButton = 0x48 };
        public static Led KeyLockLed = new Led { name = "Key Lock", baseChannel = nonPadLedsBaseChannel, ledButton = 0x1A, shiftedLedButton = 0x60 };
        public static Led PlayLed = new Led { name = "Play", baseChannel = nonPadLedsBaseChannel, ledButton = 0x0B, shiftedLedButton = 0x47 };
        public static Led VinylLed = new Led { name = "Vinyl", baseChannel = nonPadLedsBaseChannel, ledButton = 0x17, shiftedLedButton = 0x4E };
        public static Led SyncLed = new Led { name = "Sync", baseChannel = nonPadLedsBaseChannel, ledButton = 0x58, shiftedLedButton = 0x5C };
        public static Led ShiftLed = new Led { name = "Shift", baseChannel = nonPadLedsBaseChannel, ledButton = 0x3F, shiftedLedButton = 0x3F };

        public static Led DeckLed = new Led { name = "Deck", baseChannel = nonPadLedsBaseChannel, ledButton = 0x72, shiftedLedButton = 0x73 };
        public static Led PadTransLed = new Led { name = "Pad Trans", baseChannel = nonPadLedsBaseChannel, ledButton = 0x70, shiftedLedButton = 0x75 };

        public static Led HotCueLed = new Led { name = "Hot Cue", baseChannel = nonPadLedsBaseChannel, ledButton = 0x1B, shiftedLedButton = 0x69 };
        public static Led AutoLoopLed = new Led { name = "Auto Loop", baseChannel = nonPadLedsBaseChannel, ledButton = 0x1E, shiftedLedButton = 0x6B };
        public static Led ManualLoopLed = new Led { name = "Manual Loop", baseChannel = nonPadLedsBaseChannel, ledButton = 0x20, shiftedLedButton = 0x6D };
        public static Led SamplerLed = new Led { name = "Sampler", baseChannel = nonPadLedsBaseChannel, ledButton = 0x22, shiftedLedButton = 0x6F };

        // FX
        public static Led Fx1Led = new Led { name = "FX 1 Select", baseChannel = fxLedsBaseChannel, ledButton = 0x47, shiftedLedButton = 0x63 };
        public static Led Fx2Led = new Led { name = "FX 2 Select", baseChannel = fxLedsBaseChannel, ledButton = 0x48, shiftedLedButton = 0x64 };
        public static Led Fx3Led = new Led { name = "FX 3 Select", baseChannel = fxLedsBaseChannel, ledButton = 0x49, shiftedLedButton = 0x65 };

        // Pad LEDs
        public static Led InLed = new Led { name = "In", baseChannel = fxLedsBaseChannel, ledButton = 0x00, shiftedLedButton = (0x00 + 0x08) };
        public static Led OutLed = new Led { name = "Out", baseChannel = fxLedsBaseChannel, ledButton = 0x01, shiftedLedButton = (0x01 + 0x08) };
        public static Led ExitLed = new Led { name = "Exit", baseChannel = fxLedsBaseChannel, ledButton = 0x02, shiftedLedButton = (0x02 + 0x08) };
        public static Led Pad2xLed = new Led { name = "1/2X", baseChannel = fxLedsBaseChannel, ledButton = 0x03, shiftedLedButton = (0x03 + 0x08) };

        // Levels
        public static LevelLed Level = new LevelLed { name = "Level", baseChannel = channelLevelLedsBaseChannel, ledButton = 0x02 };

        public enum nonPadLeds : byte
        {
            headphoneCue = 0x54,
            shiftHeadphoneCue = 0x68,
            cue = 0x0C,
            shiftCue = 0x48,
            keyLock = 0x1A,
            shiftKeyLock = 0x60,
            play = 0x0B,
            shiftPlay = 0x47,
            vinyl = 0x17,
            shiftVinyl = 0x4E,
            sync = 0x58,
            shiftSync = 0x5C,
            shift = 0x3F

        };

        public enum fxLeds
        {
            button1 = 0x47,
            shiftButton1 = 0x63,
            button2 = 0x48,
            shiftButton2 = 0x64,
            button3 = 0x49,
            shiftButton3 = 0x65,
        };

        // Deck Button
        public static byte deckButton = 0x72;
        public static byte shiftDeckButton = 0x73;
        public static byte deckButtonOn = 0x00;
        public static byte deckButtonOff = 0x7F;

        // Pad Trans
        public static byte padTransButton = 0x70;
        public static byte shiftPadTransButton = 0x75;
        public static byte padTransButtonOn = 0x00;
        public static byte padTransButtonOff = 0x7F;

        

    }
}
