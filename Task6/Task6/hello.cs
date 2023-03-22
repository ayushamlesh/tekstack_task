using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class hello
    {
    public static void Main(string[] args)
        {
            int PId;
            string Pname;

            PId= 1;
            Pname= Console.ReadLine();
            hello ob = new hello();
            Product p = new Product(PId,Pname);
            Console.WriteLine(ob.Display(p));
        }
    public class Product
        {
            public int Id;
            public string Name;
     public Product(int id,string name)
            {
                Id = id;
                Name = name;
            }
        }



    public string Display(Product p)
        { return p.Name; }
    
    }
}
