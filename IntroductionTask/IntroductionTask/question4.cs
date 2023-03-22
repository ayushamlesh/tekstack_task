using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionTask
{
    internal class question4
    {
        public static int Swap(int num1, int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("1st number after swap {0}",num1);
            Console.WriteLine("2nd number after swap {0}",num2);
            return 0;
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the  1st number ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1st number is {0}",num1);
            Console.WriteLine("2nd number is {0}", num2);
            Swap(num1, num2);
        }
    }
}
