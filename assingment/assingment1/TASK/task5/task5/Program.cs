

namespace task5
{
    internal class Program
    {
        public static int PerformArray(int[] array)
        {
            // Sort array in ascending order.
            Array.Sort(array);
            Console.WriteLine("Sort: ");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }

            // reverse array
            Array.Reverse(array);
            Console.WriteLine("\n\nReverse: ");
            // print all element of array
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Array.Clear(array, 1, 3);
            return 0;
        }

        public static string PerformStrArray(string[] array)
        {
            Console.WriteLine("\n");
            // Sort array in ascending order.
            Array.Sort(array);
            Console.WriteLine("Sort: ");
            foreach (string value in array)
            {
                Console.Write(value + " ");
            }


            // reverse array
            Array.Reverse(array);
            Console.WriteLine("\n\nReverse: ");
            // print all element of array
            foreach (string value in array)
            {
                Console.Write(value + " ");
            }
            Array.Clear(array,1,3);
            string a = "hello";
            return a;

        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] array = new int[5];
            int[] arrayCopy = new int[5];
            Console.WriteLine("Enter 5 integers : ");
            for (int i = 0; i < 5; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            string[] array2 = new string[5];
            string[] arrayCopy2 = new string[5];
            Console.WriteLine("Enter 5 string values : ");
            for (int i = 0; i < 5; i++)
            {
                array2[i] = Console.ReadLine();
            }

            array.CopyTo(arrayCopy, 0);
            array2.CopyTo(arrayCopy2, 0);
            Console.WriteLine("Array copied");
            Console.WriteLine(String.Join(", ", arrayCopy));
            Console.WriteLine(String.Join(", ", arrayCopy2));

            
            PerformArray(array);
            PerformStrArray(array2);

        }
      
        }

    }