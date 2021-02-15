using DDJSB2.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2
{
    public class State : IState
    {
        public IControl Control { get; set; }
        public int Channel { get; set; }
        public byte Number { get; set; }
        public byte Value { get; set; }
    }
}
