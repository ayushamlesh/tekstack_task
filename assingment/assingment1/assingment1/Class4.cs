using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment1
{
    internal class Class4
    {
        public static void CalculateCirclesValues(double r,out double  area,out double circumference)
        {
            area = Math.PI * r * r;
            circumference = 2 * Math.PI * r;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius");
            double radius = Double.Parse(Console.ReadLine());
            double area, circumference;
            CalculateCirclesValues(radius, out  area, out circumference);
            Console.WriteLine("The area of the circle is:" + area);
            Console.WriteLine("The circumference of the circle is " + circumference);
            Console.ReadKey();
        }
    }
}
