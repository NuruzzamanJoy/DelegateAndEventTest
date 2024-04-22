using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventTest
{
    public class Client2
    {
        public static void YHandler(int n)
        {
            Console.WriteLine("Event received by client");
        }
    }
}
