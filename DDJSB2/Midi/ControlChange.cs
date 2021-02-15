using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2.Midi
{
    public class ControlChange : IControlChange
    {
        public string ControlName { get; set; }
        public byte ControlNumber { get; set; }
        public byte ControlValue { get; set; }

        public bool ProcessControlChangeEvent(int channel, byte controlNumber, byte controlValue)
        {
            if (ControlNumber == controlNumber)
            {
                ControlValue = controlValue;
                return true;
            }

            return false;
        }
    }
}
