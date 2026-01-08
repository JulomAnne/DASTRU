using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] candy = { "chocolate", "snowbar", "mikmik", "stick-o" };
            Array.Reverse(candy); //if reverse or sort, don't place after foreach syntax
            foreach (string candies in candy)
            {
                Console.WriteLine(candies);
            }
            Console.ReadLine();

            string[] fruit = new string[] {"Ube", "Manggo", "Watermelon", "Banana", "Strawberry", "Cherry"};
            Array.Sort(fruit);

            for (int i = 0; i < fruit.Length; i++)
            {
                Console.WriteLine(fruit[i]);
            }
            Console.ReadLine();
        }
    }
}
