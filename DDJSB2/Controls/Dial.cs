using DDJSB2.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2.Controls
{
    public class Dial : Common.ControlBase<State>, IMultpleControlChange, IControl
    {
        public string Name { get; set; }
        public IControlChange[] Controls { get; set; }

        public bool ProcessControlChangeEvent(int channel, byte controlNumber, byte controlValue)
        {
            if (Controls.Any(x => x.ProcessControlChangeEvent(channel, controlNumber, controlValue)))
            {
                Notify(new State { Control = this, Channel = channel, Number = controlNumber, Value = controlValue });
                return true;
            }

            return false;
        }
    }
}
