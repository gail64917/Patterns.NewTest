using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.NewTest.Ducks
{
    public abstract class DuckBase
    {
        public void Swim()
        {
            Console.WriteLine("SWIMING-SWIMING");
        }

        public void Duck()
        {
            Console.WriteLine("Duck! Duck!");
        }

        public abstract void Display();
    }
}
