using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventTest
{
    public class Client1
    {
        public static void XHandler (int n)
        {
            Console.WriteLine("Event received by client");
        }
    }
}
