using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment1
{
    internal class Class3
    {


        public static void SwapIntegers(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Before swapping: a = " + a + ", b = " + b);
            SwapIntegers(ref a, ref b);
            Console.WriteLine("After swapping: a = " + a + ", b = " + b);
            Console.ReadLine();
        }
    }
}