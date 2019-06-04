using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CabinetManager
{
    public delegate void EventHandlerEx<TEventArgs>(object sender, TEventArgs e);
}
