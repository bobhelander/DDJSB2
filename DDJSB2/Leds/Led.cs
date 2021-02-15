using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2
{
    public class BaseLed
    {
        public string name { get; set; }
        public byte baseChannel { get; set; }
        public byte ledButton { get; set; }
    }

    public class Led : BaseLed
    {
        public byte shiftedLedButton { get; set; }
    }

    public class LevelLed : BaseLed
    {
    }
}
