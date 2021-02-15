using DDJSB2.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2
{
    public interface IState
    {
        IControl Control { get; set; }
        int Channel { get; set; }
        byte Number { get; set; }
        byte Value { get; set; }
    }
}
