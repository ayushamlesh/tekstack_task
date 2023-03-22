using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitwareLib
{
    class Question2
    {

        static void Main(string[] args)
        {
            string custName;
            string ifsc;
            string accountNum;
            StreamReader reader = null;
            StreamWriter writer = null;
            Console.WriteLine("ENter Name: ");
            custName = Console.ReadLine();
            Console.WriteLine("Enter ifsc:");
            ifsc = Console.ReadLine();
            Console.WriteLine("Enter Account Number");
            accountNum = Console.ReadLine();


            try
            {
                writer = new StreamWriter("CustomerDetails.txt");
                writer.WriteLine("Name: "+custName);
                writer.WriteLine("Account Number: " + accountNum);
                writer.WriteLine("IFSC :"+ifsc);
                writer.Close(); 
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                reader = new StreamReader("CustomerDetails.txt"); 
               Console.WriteLine(reader.ReadToEnd());
                reader.Close();
            }
        }
    }
}
