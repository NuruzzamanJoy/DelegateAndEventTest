using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("EnterNumber");
                int number = Convert.ToInt32(Console.ReadLine());
                MyMethod method = new MyMethod();
                MakeDelegate del;
                del = MyMethod.MakeSquare;
                del += MyMethod.MakeCube;
                del.Invoke(number);

                EventNotification notification = new EventNotification();
                notification.delegateEvent += Client1.XHandler;
                notification.delegateEvent += Client2.YHandler;
            }
            catch(Exception ex)  
            {
                Console.WriteLine(ex.Message);   
            }   
            finally 
            {
                Console.ReadLine(); 
            } 

        }
    }
}
