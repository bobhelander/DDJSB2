# DDJSB2
Pioneer DDJ-SB2 Reactive Library

https://www.pioneerdj.com/en-us/product/controller/archive/ddj-sb2/black/overview/



#### Simple Usage

```
using System.Linq;
using System.Reactive;

using(var ddjsb2 = Factory.CreateInstance())
{
    // Deck 1 Left side
    var deckNumber = 1;

    // Find the button "Play" on Deck 1 and write to the console when pressed or released
    var playSubscription = (ddjsb2.ChannelControls[deckNumber].First(x => x.Name == "Play") as Button)
        .Subscribe(x => Console.WriteLine("Play Button Event"), ex => Console.WriteLine($"Exception : {ex}"));

    // Find the button "Cue" on Deck 2 light the button LED when pressed and perform an action
    var cueSubscription = (ddjsb2.ChannelControls[2].First(x => x.Name == "Cue") as Button)
        .Subscribe(x => ButtonEvent(ddjsb2, Leds.Deck.Deck2, x), ex => Console.WriteLine($"Exception : {ex}"));

    // Wait until shutdown

    playSubscription.Dispose();
    cueSubscription.Dispose();
}

private static void ButtonEvent(PioneerDDJSB2 ddjsb2, Leds.Deck deck, IState state)
{
    Console.WriteLine($"Button Event: {state.Control.Name}");

    var button = state.Control as Button;
    var on = button.NoteValue > 0;

    // Light the LED when pressed
    ddjsb2.LedControl(deck, Leds.CueLed, false, on);

    if (on)
    {
        // Do something
    }
}
```