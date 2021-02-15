using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2
{
    public interface IControlChange : IControlChangeHandler
    {
        string ControlName { get; set; }
        byte ControlNumber { get; set; }
        byte ControlValue { get; set; }
    }
}
