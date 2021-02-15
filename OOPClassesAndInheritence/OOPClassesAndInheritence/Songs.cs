using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassesAndInheritence
{
    class Songs : Objects
    {

        public Songs(string _SongName = null)
        {
            Name = _SongName;
            Console.WriteLine("Song " + _SongName + " lasting " + SongDuration + " created on " + DateTime.Now.ToString("yyyy-MM-dd"));
        }
    }
}
