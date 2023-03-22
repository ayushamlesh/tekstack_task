using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionTask
{
    public class question3
    {
        public static int SumArray(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                sum += item;
            }
            return sum;

        }
        static void Main(string[] args)
        {
             int[] array =new int[5];
            Console.WriteLine("Enter 5 integers to see the sum: ");
            for(int i=0;i<5;i++)
            {
                array[i] =Convert.ToInt32(Console.ReadLine());
            }

            int ans= SumArray(array);
            Console.WriteLine(ans);

        }
    }
}
