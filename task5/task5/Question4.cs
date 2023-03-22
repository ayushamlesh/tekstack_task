using System.Collections;


namespace task5
{
    internal class Question4
    {
        public static void Main(string[] args)
        {
            // Using Stack class
            Stack my_stack = new Stack();

            // Adding elements in the Stack
            // Using Push method
            my_stack.Push("Hello");
            my_stack.Push("Hi");
            my_stack.Push("oli");
            my_stack.Push("nokli");
            my_stack.Push(7761);
            my_stack.Pop();
            my_stack.Pop();

            // Accessing the elements
            // of my_stack Stack
            // Using foreach loop
            foreach (var em in my_stack)
            {
                Console.WriteLine(em);
            }
        }
    }

    }
