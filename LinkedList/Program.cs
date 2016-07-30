using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linked = new LinkedList<string>();


            linked.AddLast("C#");
            linked.AddLast("C++");
            linked.AddLast("Java");
            linked.AddFirst("SQL"); 

            foreach (var item in linked)
            {
                Console.WriteLine(item);
            }
        }
    }
}
