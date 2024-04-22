using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventTest
{
    public class EventNotification
    {
        public event MakeDelegate delegateEvent;
        public void Notify(int x)
        {
            delegateEvent(x);
        }
    }
}
