using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClassesAndInheritence
{
    class Members
    {
        public string MemberName;

        public Members(string _name = null)
        {
            MemberName = _name;

            Console.WriteLine("Member " + _name + " created at " + DateTime.Now.ToString("yyyy-MM-dd"));
        }
    }
}
