using Patterns.NewTest.FlyExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.NewTest.Ducks
{
    class RubberDuck : DuckBase
    {
        public RubberDuck()
        {
            flyBehaviour = new NoFly();
        }

        public override void Display()
        {
            Console.WriteLine("I`m rubber duck!");
        }
    }
}
