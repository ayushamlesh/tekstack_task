using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment1
{
    internal class Class1

    {
        static void Main(string[] args) {
            int[] marks = new int[5];
            Console.WriteLine("Enter the marks of 5 Student");
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum  = sum + marks[i];


            }
            double result = sum / 5;
            Console.WriteLine("the avarage marks of 5 students is " + result);
        }
    }
}
