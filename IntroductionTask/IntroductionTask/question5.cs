using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionTask
{
    internal class question5
    {
        public static int Area(int radius)
        {
            float area,circunference;
            area = (float)(3.14 * (radius*radius));
            circunference= (float)(2*(3.14 * radius));
            Console.WriteLine("area is "+area);
            Console.WriteLine("circunference is "+circunference);
            return 0;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius");
            int radius = int.Parse(Console.ReadLine());
            Area(radius);
        }
    }
}
