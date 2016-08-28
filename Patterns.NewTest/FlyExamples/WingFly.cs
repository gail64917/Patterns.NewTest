﻿using Patterns.NewTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.NewTest.FlyExamples
{
    public class WingFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings");
        }
    }
}
