using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEventTest
{
    public delegate void MakeDelegate(int num);
        
    public class MyMethod
    {
        public static int Cube(int num) 
        {
            return num*num*num; 
        }
        public static  int Square(int num)
        {
            return num * num;
        }

        public static void MakeCube(int num)
        {
            Console.WriteLine("Cube of the number is" + Cube(num));
        }
        public static void MakeSquare(int num)
        {
            Console.WriteLine("Square of the number is" + Square(num));
        }



    }
}
