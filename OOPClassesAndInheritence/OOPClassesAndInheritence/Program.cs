using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassesAndInheritence
{
    class Program : Objects
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
                Albums ht = new Albums("Hybrid Theory", "10, 24, 2000", Genre.NuMetal);
                ht.thisGenre = Genre.NuMetal;

                Songs ht1 = new Songs("Papercut", 185f);
                ht1.SongDuration = 185f;

                Songs ht2 = new Songs("One Step Closer", 157f);
                ht2.SongDuration = 157f;

                Songs ht3 = new Songs("With You", 203f);
                ht3.SongDuration = 203f;

                Songs ht4 = new Songs("Points of Authority", 200f);
                ht4.SongDuration = 200f;

                Songs ht5 = new Songs("Crawling", 209f);
                ht5.SongDuration = 209f;

                Songs ht6 = new Songs("Runaway", 184f);
                ht6.SongDuration = 184f;

                Songs ht7 = new Songs("By Myself", 190f);
                ht7.SongDuration = 190f;

                Songs ht8 = new Songs("In the End", 217f);
                ht8.SongDuration = 217f;

                Songs ht9 = new Songs("A Place for My Head", 185f);
                ht9.SongDuration = 185f;

                Songs ht10 = new Songs("Forgotten", 194f);
                ht10.SongDuration = 194f;

                Songs ht11 = new Songs("Cure for the Itch", 157f);
                ht11.SongDuration = 157f;

                Songs ht12 = new Songs("Pushing Me Away", 191f);
                ht12.SongDuration = 191f;

                Songs ht13 = new Songs("My December", 261f);
                ht13.SongDuration = 261f;

                Songs ht14 = new Songs("High Voltage", 225f);
                ht14.SongDuration = 225f;
            }
            else if (newAlbum == 2)
            {
                Albums mt = new Albums("Meteora", "3, 25, 2003", Genre.NuMetal);
                mt.thisGenre = Genre.NuMetal;

                Songs mt1 = new Songs("Foreword", 13f);
                mt1.SongDuration = 13f;

                Songs mt2 = new Songs("Don't Stay", 188f);
                mt2.SongDuration = 188f;

                Songs mt3 = new Songs("Somewhere I Belong", 214f);
                mt3.SongDuration = 214f;

                Songs mt4 = new Songs("Lying from You", 175f);
                mt4.SongDuration = 175f;

                Songs mt5 = new Songs("Hit the Floor", 164f);
                mt5.SongDuration = 164f;

                Songs mt6 = new Songs("Easier to Run", 204f);
                mt6.SongDuration = 204f;

                Songs mt7 = new Songs("Faint", 163f);
                mt7.SongDuration = 163f;

                Songs mt8 = new Songs("Figure.09", 198f);
                mt8.SongDuration = 198f;

                Songs mt9 = new Songs("Breaking the Habit", 197f);
                mt9.SongDuration = 197f;

                Songs mt10 = new Songs("From the Inside", 174f);
                mt10.SongDuration = 174f;

                Songs mt11 = new Songs("Nobody's Listening", 179f);
                mt11.SongDuration = 179f;

                Songs mt12 = new Songs("Session", 144f);
                mt12.SongDuration = 144f;

                Songs mt13 = new Songs("Numb", 186f);
                mt13.SongDuration = 186f;
            }
            else if (newAlbum == 3)
            {
                Albums mtm = new Albums("Minutes to Midnight", "5, 14, 2007", Genre.AlternativeRock);
                mtm.thisGenre = Genre.AlternativeRock;

                Songs mtm1 = new Songs("Wake", 101f);
                mtm1.SongDuration = 101f;

                Songs mtm2 = new Songs("Given Up", 189f);
                mtm2.SongDuration = 189f;

                Songs mtm3 = new Songs("Leave Out All The Rest", 209f);
                mtm3.SongDuration = 209f;

                Songs mtm4 = new Songs("Bleed It Out", 166f);
                mtm4.SongDuration = 166f;

                Songs mtm5 = new Songs("Shadow of the Day", 290f);
                mtm5.SongDuration = 290f;

                Songs mtm6 = new Songs("What I've Done", 206f);
                mtm6.SongDuration = 206f;

                Songs mtm7 = new Songs("Hands Held High", 233f);
                mtm7.SongDuration = 233f;

                Songs mtm8 = new Songs("No More Sorrow", 222f);
                mtm8.SongDuration = 222f;

                Songs mtm9 = new Songs("Valentine's Day", 197f);
                mtm9.SongDuration = 197f;

                Songs mtm10 = new Songs("In Between", 197f);
                mtm10.SongDuration = 197f;

                Songs mtm11 = new Songs("In Pieces", 218f);
                mtm11.SongDuration = 218f;

                Songs mtm12 = new Songs("The Little Thing Give You Away", 384f);
                mtm12.SongDuration = 384f;
            }
            else if (newAlbum == 4)
            {
                Albums ts = new Albums("A Thousand Suns", "9, 8, 2010", Genre.AlternativeRock);
                ts.thisGenre = Genre.AlternativeRock;

                Songs ts1 = new Songs("The Requiem", 121f);
                ts1.SongDuration = 121f;

                Songs ts2 = new Songs("The Radiance", 58f);
                ts2.SongDuration = 58f;

                Songs ts3 = new Songs("Burning in the Skies", 253f);
                ts3.SongDuration = 253f;

                Songs ts4 = new Songs("Empty Spaces", 18f);
                ts4.SongDuration = 18f;

                Songs ts5 = new Songs("When They Come for Me", 293f);
                ts5.SongDuration = 293f;

                Songs ts6 = new Songs("Robot Boy", 269f);
                ts6.SongDuration = 269f;

                Songs ts7 = new Songs("Jornada Del Muerto", 95f);
                ts7.SongDuration = 95f;

                Songs ts8 = new Songs("Waiting for the End", 232f);
                ts8.SongDuration = 232f;

                Songs ts9 = new Songs("Blackout", 279f);
                ts9.SongDuration = 279f;

                Songs ts10 = new Songs("Wretches and Kings", 251f);
                ts10.SongDuration = 251f;

                Songs ts11 = new Songs("Wisdom, Justice, and Love", 99f);
                ts11.SongDuration = 99f;

                Songs ts12 = new Songs("Iridescent", 297f);
                ts12.SongDuration = 297f;

                Songs ts13 = new Songs("Fallout", 83f);
                ts13.SongDuration = 83f;

                Songs ts14 = new Songs("The Catalyst", 340f);
                ts14.SongDuration = 340f;

                Songs ts15 = new Songs("The Messenger", 182f);
                ts15.SongDuration = 182f;
            }
            else if (newAlbum == 5)
            {
                Albums lt = new Albums("LIVING THINGS", "6, 20, 2012", Genre.ElectronicRock);
                lt.thisGenre = Genre.ElectronicRock;

                Songs lt1 = new Songs("LOST IN THE ECHO", 205f);
                lt1.SongDuration = 205f;

                Songs lt2 = new Songs("IN MY REMAINS", 201f);
                lt2.SongDuration = 201f;

                Songs lt3 = new Songs("BURN IT DOWN", 230f);
                lt3.SongDuration = 230f;

                Songs lt4 = new Songs("LIES GREED MISERY", 146f);
                lt4.SongDuration = 146f;

                Songs lt5 = new Songs("I'LL BE GONE", 211f);
                lt5.SongDuration = 211f;

                Songs lt6 = new Songs("CASTLE OF GLASS", 205f);
                lt6.SongDuration = 205f;

                Songs lt7 = new Songs("VICTIMIZED", 106f);
                lt7.SongDuration = 106f;

                Songs lt8 = new Songs("ROADS UNTRAVELED", 230f);
                lt8.SongDuration = 230f;

                Songs lt9 = new Songs("SKIN TO BONE", 168f);
                lt9.SongDuration = 168f;

                Songs lt10 = new Songs("UNTIL IT BREAKS", 223f);
                lt10.SongDuration = 223f;

                Songs lt11 = new Songs("TINFOIL", 72f);
                lt11.SongDuration = 72f;

                Songs lt12 = new Songs("POWERLESS", 224f);
                lt12.SongDuration = 224f;
            }
            else if (newAlbum == 6)
            {
                Albums hp = new Albums("The Hunting Party", "6, 14, 2014", Genre.AlternativeRock);
                hp.thisGenre = Genre.AlternativeRock;

                Songs hp1 = new Songs("Keys to the Kingdom", 219f);
                hp1.SongDuration = 219f;

                Songs hp2 = new Songs("All for Nothing(feat. Page Hamilton)", 214f);
                hp2.SongDuration = 214f;

                Songs hp3 = new Songs("Guilty All the Same(feat. Rakim)", 355f);
                hp3.SongDuration = 355f;

                Songs hp4 = new Songs("The Summoning", 60f);
                hp4.SongDuration = 60f;

                Songs hp5 = new Songs("War", 131f);
                hp5.SongDuration = 131f;

                Songs hp6 = new Songs("Wastelands", 196f);
                hp6.SongDuration = 196f;

                Songs hp7 = new Songs("Until It's Gone", 233f);
                hp7.SongDuration = 233f;

                Songs hp8 = new Songs("Rebellion(feat. Daron Malakian)", 224f);
                hp8.SongDuration = 224f;

                Songs hp9 = new Songs("Mark the Graves", 305f);
                hp9.SongDuration = 305f;

                Songs hp10 = new Songs("Drawbar(feat. Tom Morello)", 167f);
                hp10.SongDuration = 167f;

                Songs hp11 = new Songs("Final Masquerade", 218f);
                hp11.SongDuration = 218f;

                Songs hp12 = new Songs("A Line in the Sand", 395f);
                hp12.SongDuration = 395f;
            }
            else if (newAlbum == 7)
            {
                Albums oml = new Albums("One More Light", "5, 19, 2017", Genre.PopRock);
                oml.thisGenre = Genre.PopRock;

                Songs oml1 = new Songs("Nobody Can Save Me", 226f);
                oml1.SongDuration = 226f;

                Songs oml2 = new Songs("Good Goodbye(feat. Pusha T and Stormzy)", 211f);
                oml2.SongDuration = 211f;

                Songs oml3 = new Songs("Talking to Myself", 231f);
                oml3.SongDuration = 231f;

                Songs oml4 = new Songs("Battle Symphony", 216f);
                oml4.SongDuration = 216f;

                Songs oml5 = new Songs("Invisible", 214f);
                oml5.SongDuration = 214f;

                Songs oml6 = new Songs("Heavy(feat. Kiiara)", 170f);
                oml6.SongDuration = 170f;

                Songs oml7 = new Songs("Sorry for Now", 204f);
                oml7.SongDuration = 204f;

                Songs oml8 = new Songs("Halfway Right", 217f);
                oml8.SongDuration = 217f;

                Songs oml9 = new Songs("One More Light", 255f);
                oml9.SongDuration = 255f;

                Songs oml10 = new Songs("Sharp Edges", 178f);
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

                        if (newAlbum == 1)
                        {
                            Albums ht = new Albums("Hybrid Theory", "10, 24, 2000", Genre.NuMetal);
                            ht.thisGenre = Genre.NuMetal;

                            Songs ht1 = new Songs("Papercut", 185f);
                            ht1.SongDuration = 185f;

                            Songs ht2 = new Songs("One Step Closer", 157f);
                            ht2.SongDuration = 157f;

                            Songs ht3 = new Songs("With You", 203f);
                            ht3.SongDuration = 203f;

                            Songs ht4 = new Songs("Points of Authority", 200f);
                            ht4.SongDuration = 200f;

                            Songs ht5 = new Songs("Crawling", 209f);
                            ht5.SongDuration = 209f;

                            Songs ht6 = new Songs("Runaway", 184f);
                            ht6.SongDuration = 184f;

                            Songs ht7 = new Songs("By Myself", 190f);
                            ht7.SongDuration = 190f;

                            Songs ht8 = new Songs("In the End", 217f);
                            ht8.SongDuration = 217f;

                            Songs ht9 = new Songs("A Place for My Head", 185f);
                            ht9.SongDuration = 185f;

                            Songs ht10 = new Songs("Forgotten", 194f);
                            ht10.SongDuration = 194f;

                            Songs ht11 = new Songs("Cure for the Itch", 157f);
                            ht11.SongDuration = 157f;

                            Songs ht12 = new Songs("Pushing Me Away", 191f);
                            ht12.SongDuration = 191f;

                            Songs ht13 = new Songs("My December", 261f);
                            ht13.SongDuration = 261f;

                            Songs ht14 = new Songs("High Voltage", 225f);
                            ht14.SongDuration = 225f;
                        }
                        else if (newAlbum == 2)
                        {
                            Albums mt = new Albums("Meteora", "3, 25, 2003", Genre.NuMetal);
                            mt.thisGenre = Genre.NuMetal;

                            Songs mt1 = new Songs("Foreword", 13f);
                            mt1.SongDuration = 13f;

                            Songs mt2 = new Songs("Don't Stay", 188f);
                            mt2.SongDuration = 188f;

                            Songs mt3 = new Songs("Somewhere I Belong", 214f);
                            mt3.SongDuration = 214f;

                            Songs mt4 = new Songs("Lying from You", 175f);
                            mt4.SongDuration = 175f;

                            Songs mt5 = new Songs("Hit the Floor", 164f);
                            mt5.SongDuration = 164f;

                            Songs mt6 = new Songs("Easier to Run", 204f);
                            mt6.SongDuration = 204f;

                            Songs mt7 = new Songs("Faint", 163f);
                            mt7.SongDuration = 163f;

                            Songs mt8 = new Songs("Figure.09", 198f);
                            mt8.SongDuration = 198f;

                            Songs mt9 = new Songs("Breaking the Habit", 197f);
                            mt9.SongDuration = 197f;

                            Songs mt10 = new Songs("From the Inside", 174f);
                            mt10.SongDuration = 174f;

                            Songs mt11 = new Songs("Nobody's Listening", 179f);
                            mt11.SongDuration = 179f;

                            Songs mt12 = new Songs("Session", 144f);
                            mt12.SongDuration = 144f;

                            Songs mt13 = new Songs("Numb", 186f);
                            mt13.SongDuration = 186f;
                        }
                        else if (newAlbum == 3)
                        {
                            Albums mtm = new Albums("Minutes to Midnight", "5, 14, 2007", Genre.AlternativeRock);
                            mtm.thisGenre = Genre.AlternativeRock;

                            Songs mtm1 = new Songs("Wake", 101f);
                            mtm1.SongDuration = 101f;

                            Songs mtm2 = new Songs("Given Up", 189f);
                            mtm2.SongDuration = 189f;

                            Songs mtm3 = new Songs("Leave Out All The Rest", 209f);
                            mtm3.SongDuration = 209f;

                            Songs mtm4 = new Songs("Bleed It Out", 166f);
                            mtm4.SongDuration = 166f;

                            Songs mtm5 = new Songs("Shadow of the Day", 290f);
                            mtm5.SongDuration = 290f;

                            Songs mtm6 = new Songs("What I've Done", 206f);
                            mtm6.SongDuration = 206f;

                            Songs mtm7 = new Songs("Hands Held High", 233f);
                            mtm7.SongDuration = 233f;

                            Songs mtm8 = new Songs("No More Sorrow", 222f);
                            mtm8.SongDuration = 222f;

                            Songs mtm9 = new Songs("Valentine's Day", 197f);
                            mtm9.SongDuration = 197f;

                            Songs mtm10 = new Songs("In Between", 197f);
                            mtm10.SongDuration = 197f;

                            Songs mtm11 = new Songs("In Pieces", 218f);
                            mtm11.SongDuration = 218f;

                            Songs mtm12 = new Songs("The Little Thing Give You Away", 384f);
                            mtm12.SongDuration = 384f;
                        }
                        else if (newAlbum == 4)
                        {
                            Albums ts = new Albums("A Thousand Suns", "9, 8, 2010", Genre.AlternativeRock);
                            ts.thisGenre = Genre.AlternativeRock;

                            Songs ts1 = new Songs("The Requiem", 121f);
                            ts1.SongDuration = 121f;

                            Songs ts2 = new Songs("The Radiance", 58f);
                            ts2.SongDuration = 58f;

                            Songs ts3 = new Songs("Burning in the Skies", 253f);
                            ts3.SongDuration = 253f;

                            Songs ts4 = new Songs("Empty Spaces", 18f);
                            ts4.SongDuration = 18f;

                            Songs ts5 = new Songs("When They Come for Me", 293f);
                            ts5.SongDuration = 293f;

                            Songs ts6 = new Songs("Robot Boy", 269f);
                            ts6.SongDuration = 269f;

                            Songs ts7 = new Songs("Jornada Del Muerto", 95f);
                            ts7.SongDuration = 95f;

                            Songs ts8 = new Songs("Waiting for the End", 232f);
                            ts8.SongDuration = 232f;

                            Songs ts9 = new Songs("Blackout", 279f);
                            ts9.SongDuration = 279f;

                            Songs ts10 = new Songs("Wretches and Kings", 251f);
                            ts10.SongDuration = 251f;

                            Songs ts11 = new Songs("Wisdom, Justice, and Love", 99f);
                            ts11.SongDuration = 99f;

                            Songs ts12 = new Songs("Iridescent", 297f);
                            ts12.SongDuration = 297f;

                            Songs ts13 = new Songs("Fallout", 83f);
                            ts13.SongDuration = 83f;

                            Songs ts14 = new Songs("The Catalyst", 340f);
                            ts14.SongDuration = 340f;

                            Songs ts15 = new Songs("The Messenger", 182f);
                            ts15.SongDuration = 182f;
                        }
                        else if (newAlbum == 5)
                        {
                            Albums lt = new Albums("LIVING THINGS", "6, 20, 2012", Genre.ElectronicRock);
                            lt.thisGenre = Genre.ElectronicRock;

                            Songs lt1 = new Songs("LOST IN THE ECHO", 205f);
                            lt1.SongDuration = 205f;

                            Songs lt2 = new Songs("IN MY REMAINS", 201f);
                            lt2.SongDuration = 201f;

                            Songs lt3 = new Songs("BURN IT DOWN", 230f);
                            lt3.SongDuration = 230f;

                            Songs lt4 = new Songs("LIES GREED MISERY", 146f);
                            lt4.SongDuration = 146f;

                            Songs lt5 = new Songs("I'LL BE GONE", 211f);
                            lt5.SongDuration = 211f;

                            Songs lt6 = new Songs("CASTLE OF GLASS", 205f);
                            lt6.SongDuration = 205f;

                            Songs lt7 = new Songs("VICTIMIZED", 106f);
                            lt7.SongDuration = 106f;

                            Songs lt8 = new Songs("ROADS UNTRAVELED", 230f);
                            lt8.SongDuration = 230f;

                            Songs lt9 = new Songs("SKIN TO BONE", 168f);
                            lt9.SongDuration = 168f;

                            Songs lt10 = new Songs("UNTIL IT BREAKS", 223f);
                            lt10.SongDuration = 223f;

                            Songs lt11 = new Songs("TINFOIL", 72f);
                            lt11.SongDuration = 72f;

                            Songs lt12 = new Songs("POWERLESS", 224f);
                            lt12.SongDuration = 224f;
                        }
                        else if (newAlbum == 6)
                        {
                            Albums hp = new Albums("The Hunting Party", "6, 14, 2014", Genre.AlternativeRock);
                            hp.thisGenre = Genre.AlternativeRock;

                            Songs hp1 = new Songs("Keys to the Kingdom", 219f);
                            hp1.SongDuration = 219f;

                            Songs hp2 = new Songs("All for Nothing(feat. Page Hamilton)", 214f);
                            hp2.SongDuration = 214f;

                            Songs hp3 = new Songs("Guilty All the Same(feat. Rakim)", 355f);
                            hp3.SongDuration = 355f;

                            Songs hp4 = new Songs("The Summoning", 60f);
                            hp4.SongDuration = 60f;

                            Songs hp5 = new Songs("War", 131f);
                            hp5.SongDuration = 131f;

                            Songs hp6 = new Songs("Wastelands", 196f);
                            hp6.SongDuration = 196f;

                            Songs hp7 = new Songs("Until It's Gone", 233f);
                            hp7.SongDuration = 233f;

                            Songs hp8 = new Songs("Rebellion(feat. Daron Malakian)", 224f);
                            hp8.SongDuration = 224f;

                            Songs hp9 = new Songs("Mark the Graves", 305f);
                            hp9.SongDuration = 305f;

                            Songs hp10 = new Songs("Drawbar(feat. Tom Morello)", 167f);
                            hp10.SongDuration = 167f;

                            Songs hp11 = new Songs("Final Masquerade", 218f);
                            hp11.SongDuration = 218f;

                            Songs hp12 = new Songs("A Line in the Sand", 395f);
                            hp12.SongDuration = 395f;
                        }
                        else if (newAlbum == 7)
                        {
                            Albums oml = new Albums("One More Light", "5, 19, 2017", Genre.PopRock);
                            oml.thisGenre = Genre.PopRock;

                            Songs oml1 = new Songs("Nobody Can Save Me", 226f);
                            oml1.SongDuration = 226f;

                            Songs oml2 = new Songs("Good Goodbye(feat. Pusha T and Stormzy)", 211f);
                            oml2.SongDuration = 211f;

                            Songs oml3 = new Songs("Talking to Myself", 231f);
                            oml3.SongDuration = 231f;

                            Songs oml4 = new Songs("Battle Symphony", 216f);
                            oml4.SongDuration = 216f;

                            Songs oml5 = new Songs("Invisible", 214f);
                            oml5.SongDuration = 214f;

                            Songs oml6 = new Songs("Heavy(feat. Kiiara)", 170f);
                            oml6.SongDuration = 170f;

                            Songs oml7 = new Songs("Sorry for Now", 204f);
                            oml7.SongDuration = 204f;

                            Songs oml8 = new Songs("Halfway Right", 217f);
                            oml8.SongDuration = 217f;

                            Songs oml9 = new Songs("One More Light", 255f);
                            oml9.SongDuration = 255f;

                            Songs oml10 = new Songs("Sharp Edges", 178f);
                            oml10.SongDuration = 178f;
                        }
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
