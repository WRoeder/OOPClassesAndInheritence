using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassesAndInheritence
{
    class Songs : Albums
    {
        public string SongTitle;
        public float SongDuration;

        public Songs(string _name = null)
        {
            Name = _name;
            Console.WriteLine("Song " + _name + "created at " + DateTime.Now.ToString("yyyy-MM-dd"));
        }
    }
}
