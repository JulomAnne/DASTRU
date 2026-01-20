using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Dimensional_Array
{
    public class Songs
    {
        //Declare properties
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }

        //Parameterized Constructor
        public Songs(string title, string artist, string genre)
        {
            Title = title;
            Artist = artist;
            Genre = genre;
        }

        //Virtual method to be overriden
        public virtual void DisplayInfo()
        {
            Console.WriteLine("\n----------| List |----------");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Genre: {Genre}");
        }
    }

    public class Music : Songs
    {
        public double Releases { get; set; } //Additional property

        //Paramterized Constructor
        public Music(string title, string artist, string genre, double releases) : base(title, artist, genre)
        {
            Releases = releases;
        }

        //Override Method to display
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Releases: {Releases}");
        }
    }

    public class Performance : Songs
    {
        public double Album { get; set; } //Additional property

        //Paramterized Constructor
        public Performance(string title, string artist, string genre, double album) : base(title, artist, genre)
        {
            Album = album;
        }

        //Override Method to display
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Album: {Album}");
        }
    }
}