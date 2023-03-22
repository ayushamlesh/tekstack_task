
namespace task5
{
    internal class Question3
    {
        public static void Main(string[] args)
        {
            LinkedList<String> my_list = new LinkedList<String>();
            int count = 0;
            // Adding elements in the LinkedList
            // Using AddLast() method
            my_list.AddLast("Ayush");
            my_list.AddLast("Suyash");
            my_list.AddLast("Shilpl");
            my_list.AddLast("Deepak");

            Console.WriteLine(" Displaying the list");

            // Accessing the elements of
            //for finding the target
            string target = "Shilpa";
            bool flag = false;

            // LinkedList Using foreach loop

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
                count++;

                
              
            }
            Console.WriteLine("Total number of employees in the list: {0}",count);

            //question5:
            foreach (string str in my_list)
            {
                if (str==target)
                {
                    Console.WriteLine("Found : {0}", target);
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Not Found : ");
            }






        }
    }
}
