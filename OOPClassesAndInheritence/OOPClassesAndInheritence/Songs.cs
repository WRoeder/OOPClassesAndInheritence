using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassesAndInheritence
{
    class Songs : Objects
    {

        public Songs(string _SongName = null, float _SongDuration = 0)
        {
            Name = _SongName;
            SongDuration = _SongDuration;
            Console.WriteLine("Song " + _SongName + " lasting " + _SongDuration + " seconds created on " + DateTime.Now.ToString("yyyy-MM-dd"));
        }
    }
}
