using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassesAndInheritence
{
    enum Genre
    {
        NuMetal, PopRock, AlternativeRock, ElectronicRock
    }

    class Albums
    {
        public string Name;
        public Genre thisGenre;
        public DateTime ReleaseDate;
        public List<Songs> SongsInAlbum;

        public Albums(string _AlbName = null)
        {
            Name = _AlbName;
            Console.WriteLine("Album " + _AlbName + " created on " + DateTime.Now.ToString("yyyy-MM-dd"));
            Console.WriteLine("This album was released on " + ReleaseDate.ToString());
            Console.WriteLine("The genre of this album is " + thisGenre);
            SongsInAlbum = new List<Songs>();
        }
    }

   
}
