using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LitwareLib
{
    class Question1
    {
        static void Main(string[] args)
        {
            //@ alloq to use "/"
            Console.WriteLine("Enter the path of the directory ");
            string Path = Console.ReadLine();

            //read all the dir using string array
            string[] Dir =Directory.GetDirectories(Path);

            //listing subdirectories
            foreach (string dir in Dir)
            {
                if (Directory.Exists(dir))
                {
                    Console.WriteLine(dir);
                    Console.WriteLine("--using DirectoryInfo below---");
                    var dirInfo=new DirectoryInfo(dir);
                    Console.WriteLine("printing last accessed time of the {0}=> {1}",dirInfo.Name,dirInfo.LastAccessTime.ToString());


                }
            } 

            //for files only txt
            //var Files=Directory.GetFiles(Path);
            var Files=Directory.GetFiles(Path,"*.txt",SearchOption.TopDirectoryOnly);

            foreach (string file in Files)
            {
                Console.WriteLine("Name of the file : "+file);
                //using FileInfo for fetching more info of file 
                var Info = new FileInfo(file);
                Console.WriteLine("Printing the creation time of the file {0}",Info.CreationTime);
            }

       

            Console.ReadLine();
        }
    }
}
