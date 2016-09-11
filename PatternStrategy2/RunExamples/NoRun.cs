using PatternStrategy2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy2.RunExamples
{
    class NoRun : IRun
    {
        public void Run()
        {
            Console.WriteLine("WARRIORS DONT RUN");
        }
    }
}
