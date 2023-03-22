using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment1
{
    internal class Class2
    {

        public static int sum(int[]arr)
        {
            int s = 0;
            for(int i=0;i<arr.Length;i++)
            {
                s += arr[i];
            }
            return s;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int result = sum(arr);
            Console.WriteLine("The sum of the elements in the array is: " + result);
            Console.ReadLine();
        }
    }
}