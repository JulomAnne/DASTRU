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

            Array.Reverse(candy); //if reversed, don't place after foreach syntax
            foreach (string candies in candy)
            {
                Console.WriteLine(candies);
            }
            Console.ReadLine();
        }
    }
}