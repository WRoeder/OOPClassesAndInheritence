using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassesAndInheritence
{
    class Members
    {
        public string Name;

        public Members(string _name = null)
        {
            Name = _name;

            Console.WriteLine("Member " + _name + " created on " + DateTime.Now.ToString("yyyy-MM-dd"));
        }
    }
}
