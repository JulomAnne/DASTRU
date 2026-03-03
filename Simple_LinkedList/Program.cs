using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();

            list.AddFirst("Janine");
            list.AddBefore(list.First, "Carmel");
            list.AddFirst("Gemma");
            list.AddAfter(list.First, "Preselle");
            list.AddLast("Pinky Rose");

            foreach (string names in list)
            {
                Console.WriteLine(names);
            }
            Console.ReadLine();
        }
    }
}