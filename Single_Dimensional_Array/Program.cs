using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Dimensional_Array
{
    class Program
    {
        //Kris Anne J. Ybañez
        //ACTIVITY 2: Single Dimensional Array of Objects in OOP
        static void Main(string[] args)
        {
            Songs[] songs = new Songs[4]; //Declare array

            //Assign values for each object
            songs[0] = new Songs("I'm Back", "Royal Deluxe", "Epic Rock");
            songs[1] = new Songs("I Only Paint in Red Now", "Lydia The Bard", "Pop");
            songs[2] = new Music("Beat It", "Michael Jackson", "Hard Rock", 150);
            songs[3] = new Performance("Dangerous", "Jorge Rivera Herrans", "New jack swing pop R&B", 10);

            //Display information in each song
            foreach(Songs song in songs)
            {
                song.DisplayInfo();
            }
            Console.ReadLine();
        }
    }
}