using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionTask
{
    internal class question2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the average marks of 5 students:");
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            decimal d = decimal.Parse(Console.ReadLine());
            decimal e = decimal.Parse(Console.ReadLine());

            if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
            {
                Console.WriteLine("The biggest number is: {0}", a);
                return;
            }
            if ((b >= a) && (b >= c) && (b >= d) && (b >= c))
            {
                Console.WriteLine("The biggest number is: {0}", b);
                return;
            }
            if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
            {
                Console.WriteLine("The biggest number is: {0}", c);
                return;
            }
            if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
            {
                Console.WriteLine("The biggest number is: {0}", d);
                return;
            }
            if ((e >= a) && (e >= b) && (e >= c) && (e >= d))
            {
                Console.WriteLine("The biggest number is: {0}", e);
                return;
            }
        }
    }
}
