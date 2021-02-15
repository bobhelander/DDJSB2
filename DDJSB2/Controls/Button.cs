using DDJSB2.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2.Controls
{
    public class Button : Common.ControlBase<State>, INoteControl, INoteChangeHandler, IControl
    {
        private byte noteValue;

        public string Name { get; set; }

        public byte NoteNumber { get; set; }
        
        public byte NoteValue { get; set; }

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
    }
}
