using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.NewTest.Ducks
{
    class SimpleDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("Hello! I`m a simple Duck.");
        }
    }
}
