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
            }

            Console.ReadLine();
        }
    }
}
