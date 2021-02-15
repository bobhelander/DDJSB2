using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2
{
    public interface IMultpleControlChange : IControlChangeHandler
    {
        IControlChange[] Controls { get; set; }
    }
}
