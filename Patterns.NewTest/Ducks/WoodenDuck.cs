using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.NewTest.Interfaces;
using Patterns.NewTest.QuackExamples;
using Patterns.NewTest.FlyExamples;

namespace Patterns.NewTest.Ducks
{
    class WoodenDuck : DuckBase 
    {
        public WoodenDuck()
        {
            flyBehaviour = new NoFly();
            quackBehaviour = new NoQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a WoodenDuck!");
        }
    }
}
