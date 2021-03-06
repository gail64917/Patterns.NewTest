﻿using Patterns.NewTest.QuackExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.NewTest.Ducks
{
    class ExoticDuck : DuckBase
    {
        public ExoticDuck()
        {
            quackBehaviour = new ExoticQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Hello! I`m a EXOTIC duck.");
        }
    }
}
