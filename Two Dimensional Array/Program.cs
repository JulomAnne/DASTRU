using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Dimensional_Array
{
    class Program
    {
        //Kris Anne J. Ybañez
        //ACTIVITY 4:  2D Array of Objects in OOP
        static void Main(string[] args)
        {
            Songs[] songs = new Songs[4]; //Declare array
            string[,] table = new string[songs.Length, 3];

            //Assign values for each object
            songs[0] = new Songs("I'm Back", "Royal Deluxe", "Epic Rock");
            songs[1] = new Songs("I Only Paint in Red Now", "Lydia The Bard", "Pop");
            songs[2] = new Music("Beat It", "Michael Jackson", "Hard Rock", 150);
            songs[3] = new Performance("Dangerous", "Jorge Rivera Herrans", "New jack swing pop R&B", 10);

            for (int i = 0; i < songs.Length; i++)
            {
                table[i, 0] = songs[i].Title;
                table[i, 1] = songs[i].Artist;
                table[i, 2] = songs[i].Genre;
            }
            Console.WriteLine("\tTitle\t\t|\tArtist\t\t|\t\tGenre\t\t|");
            Console.WriteLine("---------------------------------------------------------------------------------");

            //Display information in each song
            for (int row = 0; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    Console.Write(table[row, col].PadRight(29));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}