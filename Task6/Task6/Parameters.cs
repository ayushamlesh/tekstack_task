using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class Parameters
    {
        //DO NOT change
        public double Parameter1;
        public double Parameter2;
        public void Para(double p1,double p2)
        {
            //Implement your code here
            Parameter1=p1 ;
            Parameter2=p2 ;
       }
    }
    class Triangle : Parameters
    {
        public double AreaOfTriangle()
        {
            double area = (Parameter1 * Parameter2) / 2;
            return area;
        }
    }
    //Implement your code here

    class Rectangle : Parameters
    {
        public double AreaOfRectangle()
        {
            double area = (Parameter1 * Parameter2);
            return area;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Mono World");
            double height;
            double width;
            Console.WriteLine("Enter the Parameter1");
            height = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Parameter2");
            width = Double.Parse(Console.ReadLine());     
            Triangle t = new Triangle();
            t.Para(height, width);
            Console.WriteLine(t.AreaOfTriangle());
            Rectangle r = new Rectangle();
            r.Para(height, width);
            Console.WriteLine(r.AreaOfRectangle());
        }
    }
}
 
