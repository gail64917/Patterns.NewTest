using PatternStrategy2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy2.RunExamples
{
    class CowardRun : IRun
    {
        public void Run()
        {
            Console.WriteLine("RUNNING OUT, IM SO SCARED");
        }
    }
}
