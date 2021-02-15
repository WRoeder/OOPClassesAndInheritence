using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassesAndInheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Linkin Park Library

            Console.WriteLine("The members of Linkin Park are: ");
            Members ChesterBennington = new Members("Chester Bennington");
            Members MikeShinoda = new Members("Mike Shinoda");
            Members JoeHahn = new Members("Joe Harn");
            Members RobBourden = new Members("Rob Bourden");
            Members BradDelson = new Members("Brad Delson");
            Members DaveFarrell = new Members("Dave Farrell");

            Console.WriteLine("Linkin Park albums: ");
            Console.WriteLine("1 - Hybrid Theory ");
            Console.WriteLine("2 - Meteora ");
            Console.WriteLine("3 - Minutes to Midnight ");
            Console.WriteLine("4 - A Thousand Suns ");
            Console.WriteLine("5 - LIVING THINGS ");
            Console.WriteLine("6 - The Hunting Party ");
            Console.WriteLine("7 - One More Light ");
            Console.WriteLine("What album do you want to listen to?: ");

            int newAlbum = 0;
            newAlbum = int.Parse(Console.ReadLine());

            if (newAlbum == 1)
            {
                Albums ht = new Albums("Hybrid Theory");
                ht.ReleaseDate = new DateTime(2000, 10, 24);
                ht.thisGenre = Genre.NuMetal;

                Songs ht1 = new Songs("Papercut");
                ht1.SongDuration = 185f;

                Songs ht2 = new Songs("One Step Closer");
                ht2.SongDuration = 157f;

                Songs ht3 = new Songs("With You");
                ht3.SongDuration = 203f;

                Songs ht4 = new Songs("Points of Authority");
                ht4.SongDuration = 200f;

                Songs ht5 = new Songs("Crawling");
                ht5.SongDuration = 209f;

                Songs ht6 = new Songs("Runaway");
                ht6.SongDuration = 184f;

                Songs ht7 = new Songs("By Myself");
                ht7.SongDuration = 190f;

                Songs ht8 = new Songs("In the End");
                ht8.SongDuration = 217f;

                Songs ht9 = new Songs("A Place for My Head");
                ht9.SongDuration = 185f;

                Songs ht10 = new Songs("Forgotten");
                ht10.SongDuration = 194f;

                Songs ht11 = new Songs("Cure for the Itch");
                ht11.SongDuration = 157f;

                Songs ht12 = new Songs("Pushing Me Away");
                ht12.SongDuration = 191f;

                Songs ht13 = new Songs("My December");
                ht13.SongDuration = 261f;

                Songs ht14 = new Songs("High Voltage");
                ht14.SongDuration = 225f;
            }
            else if (newAlbum == 2)
            {

            }

            Console.ReadLine();
        }
    }
}
