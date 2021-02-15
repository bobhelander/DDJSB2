using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJSB2.Common
{
    public partial class ControlBase<T> : IDisposable where T : IState, new()
    {
        /// <summary>
        /// Shutdown
        /// </summary>
        public void Dispose()
        {
            //ControllerUnsubscriber?.Dispose();
        }
    }
}
