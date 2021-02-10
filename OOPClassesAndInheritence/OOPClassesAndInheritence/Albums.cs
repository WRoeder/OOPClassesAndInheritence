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

    class Albums : Members
    {
        public Genre thisGenre;
        public DateTime ReleaseDate;
        public List<Songs> SongsInAlbum;

        public Albums(string _name = null)
        {
            Name = _name;
            Console.WriteLine("Album " + _name + " created on " + DateTime.Now.ToString("yyyy-MM-dd"));
            Console.WriteLine("This album was released on " + ReleaseDate.ToString());
            Console.WriteLine("The genre of this album is " + thisGenre);
            SongsInAlbum = new List<Songs>();
        }
    }

   
}
