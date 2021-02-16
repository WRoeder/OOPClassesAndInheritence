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
                Albums mt = new Albums("Meteora");
                mt.ReleaseDate = new DateTime(2003, 3, 25);
                mt.thisGenre = Genre.NuMetal;

                Songs mt1 = new Songs("Foreword");
                mt1.SongDuration = 13f;

                Songs mt2 = new Songs("Don't Stay");
                mt2.SongDuration = 188f;

                Songs mt3 = new Songs("Somewhere I Belong");
                mt3.SongDuration = 214f;

                Songs mt4 = new Songs("Lying from You");
                mt4.SongDuration = 175f;

                Songs mt5 = new Songs("Hit the Floor");
                mt5.SongDuration = 164f;

                Songs mt6 = new Songs("Easier to Run");
                mt6.SongDuration = 204f;

                Songs mt7 = new Songs("Faint");
                mt7.SongDuration = 163f;

                Songs mt8 = new Songs("Figure.09");
                mt8.SongDuration = 198f;

                Songs mt9 = new Songs("Breaking the Habit");
                mt9.SongDuration = 197f;

                Songs mt10 = new Songs("From the Inside");
                mt10.SongDuration = 174f;

                Songs mt11 = new Songs("Nobody's Listening");
                mt11.SongDuration = 179f;

                Songs mt12 = new Songs("Session");
                mt12.SongDuration = 144f;

                Songs mt13 = new Songs("Numb");
                mt13.SongDuration = 186f;
            }
            else if (newAlbum == 3)
            {
                Albums mtm = new Albums("Minutes to Midnight");
                mtm.ReleaseDate = new DateTime(2007, 5, 14);
                mtm.thisGenre = Genre.AlternativeRock;

                Songs mtm1 = new Songs("Wake");
                mtm1.SongDuration = 101f;

                Songs mtm2 = new Songs("Given Up");
                mtm2.SongDuration = 189f;

                Songs mtm3 = new Songs("Leave Out All The Rest");
                mtm3.SongDuration = 209f;

                Songs mtm4 = new Songs("Bleed It Out");
                mtm4.SongDuration = 166f;

                Songs mtm5 = new Songs("Shadow of the Day");
                mtm5.SongDuration = 290f;

                Songs mtm6 = new Songs("What I've Done");
                mtm6.SongDuration = 206f;

                Songs mtm7 = new Songs("Hands Held High");
                mtm7.SongDuration = 233f;

                Songs mtm8 = new Songs("No More Sorrow");
                mtm8.SongDuration = 222f;

                Songs mtm9 = new Songs("Valentine's Day");
                mtm9.SongDuration = 197f;

                Songs mtm10 = new Songs("In Between");
                mtm10.SongDuration = 197f;

                Songs mtm11 = new Songs("In Pieces");
                mtm11.SongDuration = 218f;

                Songs mtm12 = new Songs("The Little Thing Give You Away");
                mtm12.SongDuration = 384f;
            }
            else if (newAlbum == 4)
            {
                Albums ts = new Albums("A Thousand Suns");
                ts.ReleaseDate = new DateTime(2010, 9, 8);
                ts.thisGenre = Genre.AlternativeRock;

                Songs ts1 = new Songs("The Requiem");
                ts1.SongDuration = 121f;

                Songs ts2 = new Songs("The Radiance");
                ts2.SongDuration = 58f;

                Songs ts3 = new Songs("Burning in the Skies");
                ts3.SongDuration = 253f;

                Songs ts4 = new Songs("Empty Spaces");
                ts4.SongDuration = 18f;

                Songs ts5 = new Songs("When They Come for Me");
                ts5.SongDuration = 293f;

                Songs ts6 = new Songs("Robot Boy");
                ts6.SongDuration = 269f;

                Songs ts7 = new Songs("Jornada Del Muerto");
                ts7.SongDuration = 95f;

                Songs ts8 = new Songs("Waiting for the End");
                ts8.SongDuration = 232f;

                Songs ts9 = new Songs("Blackout");
                ts9.SongDuration = 279f;

                Songs ts10 = new Songs("Wretches and Kings");
                ts10.SongDuration = 251f;

                Songs ts11 = new Songs("Wisdom, Justice, and Love");
                ts11.SongDuration = 99f;

                Songs ts12 = new Songs("Iridescent");
                ts12.SongDuration = 297f;

                Songs ts13 = new Songs("Fallout");
                ts13.SongDuration = 83f;

                Songs ts14 = new Songs("The Catalyst");
                ts14.SongDuration = 340f;

                Songs ts15 = new Songs("The Messenger");
                ts15.SongDuration = 182f;
            }
            else if (newAlbum == 5)
            {
                Albums lt = new Albums("LIVING THINGS");
                lt.ReleaseDate = new DateTime(2012, 6, 20);
                lt.thisGenre = Genre.ElectronicRock;

                Songs lt1 = new Songs("LOST IN THE ECHO");
                lt1.SongDuration = 205f;

                Songs lt2 = new Songs("IN MY REMAINS");
                lt2.SongDuration = 201f;

                Songs lt3 = new Songs("BURN IT DOWN");
                lt3.SongDuration = 230f;

                Songs lt4 = new Songs("LIES GREED MISERY");
                lt4.SongDuration = 146f;

                Songs lt5 = new Songs("I'LL BE GONE");
                lt5.SongDuration = 211f;

                Songs lt6 = new Songs("CASTLE OF GLASS");
                lt6.SongDuration = 205f;

                Songs lt7 = new Songs("VICTIMIZED");
                lt7.SongDuration = 106f;

                Songs lt8 = new Songs("ROADS UNTRAVELED");
                lt8.SongDuration = 230f;

                Songs lt9 = new Songs("SKIN TO BONE");
                lt9.SongDuration = 168f;

                Songs lt10 = new Songs("UNTIL IT BREAKS");
                lt10.SongDuration = 223f;

                Songs lt11 = new Songs("TINFOIL");
                lt11.SongDuration = 72f;

                Songs lt12 = new Songs("POWERLESS");
                lt12.SongDuration = 224f;
            }
            else if (newAlbum == 6)
            {
                Albums hp = new Albums("The Hunting Party");
                hp.ReleaseDate = new DateTime(2014, 6, 14);
                hp.thisGenre = Genre.AlternativeRock;

                Songs hp1 = new Songs("Keys to the Kingdom");
                hp1.SongDuration = 219f;

                Songs hp2 = new Songs("All for Nothing(feat. Page Hamilton)");
                hp2.SongDuration = 214f;

                Songs hp3 = new Songs("Guilty All the Same(feat. Rakim)");
                hp3.SongDuration = 355f;

                Songs hp4 = new Songs("The Summoning");
                hp4.SongDuration = 60f;

                Songs hp5 = new Songs("War");
                hp5.SongDuration = 131f;

                Songs hp6 = new Songs("Wastelands");
                hp6.SongDuration = 196f;

                Songs hp7 = new Songs("Until It's Gone");
                hp7.SongDuration = 233f;

                Songs hp8 = new Songs("Rebellion(feat. Daron Malakian)");
                hp8.SongDuration = 224f;

                Songs hp9 = new Songs("Mark the Graves");
                hp9.SongDuration = 305f;

                Songs hp10 = new Songs("Drawbar(feat. Tom Morello)");
                hp10.SongDuration = 167f;

                Songs hp11 = new Songs("Final Masquerade");
                hp11.SongDuration = 218f;

                Songs hp12 = new Songs("A Line in the Sand");
                hp12.SongDuration = 395f;
            }
            else if (newAlbum == 7)
            {
                Albums oml = new Albums("One More Light");
                oml.ReleaseDate = new DateTime(2017, 5, 19);
                oml.thisGenre = Genre.PopRock;

                Songs oml1 = new Songs("Nobody Can Save Me");
                oml1.SongDuration = 226f;

                Songs oml2 = new Songs("Good Goodbye(feat. Pusha T and Stormzy)");
                oml2.SongDuration = 211f;

                Songs oml3 = new Songs("Talking to Myself");
                oml3.SongDuration = 231f;

                Songs oml4 = new Songs("Battle Symphony");
                oml4.SongDuration = 216f;

                Songs oml5 = new Songs("Invisible");
                oml5.SongDuration = 214f;

                Songs oml6 = new Songs("Heavy(feat. Kiiara)");
                oml6.SongDuration = 170f;

                Songs oml7 = new Songs("Sorry for Now");
                oml7.SongDuration = 204f;

                Songs oml8 = new Songs("Halfway Right");
                oml8.SongDuration = 217f;

                Songs oml9 = new Songs("One More Light");
                oml9.SongDuration = 255f;

                Songs oml10 = new Songs("Sharp Edges");
                oml10.SongDuration = 178f;
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 - 7. ");
                while (newAlbum <= 0 || newAlbum >= 8)
                {
                    Console.WriteLine("What album do you want to listen to? ");

                    try
                    {
                        newAlbum = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

            Console.ReadLine();
        }
    }
}
