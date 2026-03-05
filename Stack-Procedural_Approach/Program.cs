using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Procedural_Approach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Name: Kris Anne J. Ybañez
            // ACTIVITY 9:  Stack in Procedural Approach
            // Section: IT401P

            int limit = 0;  int count = 0;
            while (true) // Condition
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Choose a number from 1 to 10: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    limit = int.Parse(Console.ReadLine());

                    if (limit <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nPlease enter a number greater than 0.");
                        continue;
                    }
                    else if (limit > 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Input Limit: 10");
                        continue;
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid input.");
                }
            }
            Console.Clear();

            Stack<int> stack = new Stack<int>();
            while (count < limit) //Process
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"Enter a number to add to the stack: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    stack.Push(int.Parse(Console.ReadLine()));     count++;
                    Console.Write($"Number pushed to stack.\nStack count: {stack.Count}");
                    Console.Write($"\nLimit: {count}/{limit}\n\n");
                    continue;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input.");
                    continue;
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            while (stack.Count > 0) // Display Output
            {
                Console.Write($"{stack.Pop()}---");
            }
            Console.ReadKey();
        }
    }
}