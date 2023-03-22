namespace assingment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First No.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second No.");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1 for Addition , Enter 2 for Subtraction , Enter 3 for Multiplication , Enter 4 for Division");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("sum is " + a + b);
                    break;

                case 2:
                    Console.WriteLine($"subtraction is {a} -{b}");
                    break;

                case 3:
                    Console.WriteLine("multiplication is " + a * b);
                    break;

                case 4:
                    Console.WriteLine("division is " + a / b);
                    break;
                default:
                    Console.WriteLine("You have selected wrong option");
                    break;

            }
        }
    }
}