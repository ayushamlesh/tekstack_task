using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LitwareLib
{
    [Serializable]
    public class Manager
    {

        public int Id;
        public string name;
        public int basicSalary;
    }
    public class Employee
    {

        public int code;
        public string name;
    }
    public class MarketiveExecutive
    {

        public int code;
        public string name;
        public string area;
    }
    class Question3
    {
        static void Main(string[] args)
        {
            //as per question 4 taking the data from the user.
            //an object of the check class is created to serialize it to the file Manager.txt
            Manager manageObj = new Manager();
            Console.WriteLine("Enter Manager ID");
            manageObj.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Manager Name");
            manageObj.name = Console.ReadLine();
            Console.WriteLine("Enter Manager Salary");
            manageObj.basicSalary = Convert.ToInt32(Console.ReadLine());

            //a file stream is created
            IFormatter format = new BinaryFormatter();
            Stream stream1 = new FileStream(@"Manager.txt", FileMode.Create, FileAccess.Write);
            //serialization of the object of the class check is done
            format.Serialize(stream1,manageObj);
            stream1.Close();
            //a file stream is created
            stream1 = new FileStream(@"Manager.txt", FileMode.Open, FileAccess.Read);
            //the object of the class check is deserialized
            Manager obj1 = (Manager)format.Deserialize(stream1);
            //the data is written to the console
            Console.WriteLine(obj1.Id);
            Console.WriteLine(obj1.name);
            Console.WriteLine(obj1.basicSalary);
            Console.ReadKey();
        }
    }

}

