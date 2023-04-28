using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MallardDuck : Duck
    {
        public void Fly()
        {
            Console.WriteLine("i'm fly");
        }

        public void Quack()
        {
            Console.WriteLine("quack");
        }
    }
}
