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

            Console.WriteLine("What is the name of your member?: ");
            string newMember = Console.ReadLine();

            Console.WriteLine("What album do you want to listen to?: ");
            string newAlbum = Console.ReadLine();

            Console.ReadLine();
        }
    }
}
