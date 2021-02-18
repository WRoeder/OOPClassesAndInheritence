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

    class Albums : Objects
    {

        public Albums(string _AlbName = null, string _AlbRelease = null, Genre _AlbGenre = 0)
        {
            Name = _AlbName;
            ReleaseDate = _AlbRelease;
            thisGenre = _AlbGenre;
            Console.WriteLine("Album " + _AlbName + " was released on " + _AlbRelease + " and is apart of the " + _AlbGenre + " genre.");
            SongsInAlbum = new List<Songs>();
        }
    }

   
}
