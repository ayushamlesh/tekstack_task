using System.Collections;


namespace task5
{
    internal class Question2
    {
        public static void Main(string[] args)
        {
            var arlist = new ArrayList()
                {
                    101,
                    "ak",
                    "cse"
            };
            var arlist2 = new ArrayList()
                {
                    103,
                    "kk",
                    "MCA"
            };
            arlist.AddRange(arlist2);

            //Access individual item using indexer
            foreach (var item in arlist)
                Console.Write(item + ", ");
        }

        }
    }
