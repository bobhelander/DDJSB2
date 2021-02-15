using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2
{
    public interface INoteControl
    {
        byte NoteNumber { get; set; }
        byte NoteValue { get; set; }
    }
}
