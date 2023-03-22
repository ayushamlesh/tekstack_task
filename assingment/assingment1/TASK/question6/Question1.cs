using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Question1
    {
        public delegate void EmployeeDelegate(LinkedList<string> my_list);
        public static void Main(string[] args)
        {
            LinkedList<String> my_list = new LinkedList<String>();
            // Adding elements in the LinkedList
            // Using AddLast() method
            my_list.AddLast("Ayush");
            my_list.AddLast("Suyash");
            my_list.AddLast("Shilpl");
            my_list.AddLast("Deepak");

            //creating object
            EmployeeDelegate obj = new EmployeeDelegate(Employee);
            //object for multicast for question2
            obj = obj + new EmployeeDelegate(executiveDetails);
            obj.Invoke(my_list);
            
           
        }
        public static void Employee(LinkedList<string> list)
        {
            Console.WriteLine(" Displaying the list");
            // LinkedList Using foreach loop
            foreach (string str in list)
            {
                Console.WriteLine(str);

            }
        }
        public static void executiveDetails(LinkedList<string> list)
        {
            LinkedList<String> executiveDetails = new LinkedList<String>();
            Console.WriteLine(" Displaying the list of executive detais");
            // LinkedList Using foreach loop
            executiveDetails.AddLast("AREA HEAD");
            executiveDetails.AddLast("AREA MANAGER");
            executiveDetails.AddLast("SALES");
            foreach (string str in executiveDetails)
            {
                Console.WriteLine(str);
            }
        }
    }
}
