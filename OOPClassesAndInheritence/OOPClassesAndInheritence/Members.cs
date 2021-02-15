using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassesAndInheritence
{
    class Members : Objects
    {

        public Members(string _MemName = null)
        {
            Name = _MemName;

            Console.WriteLine("Member " + _MemName + " created on " + DateTime.Now.ToString("yyyy-MM-dd"));
        }
    }
}
