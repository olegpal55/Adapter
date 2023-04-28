using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class WildTurkey : Turkey
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying in short distance.");
        }

        public void Gobble()
        {
            Console.WriteLine("goble gobble");
        }
    }
}
