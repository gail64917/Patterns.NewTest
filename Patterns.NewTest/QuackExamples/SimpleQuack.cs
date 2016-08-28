﻿using Patterns.NewTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.NewTest.QuackExamples
{
    public class SimpleQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
