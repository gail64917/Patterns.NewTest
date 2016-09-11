using PatternStrategy2.AttackExamples;
using PatternStrategy2.RunExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy2.Warriors
{
    class SmallWarrior : WarriorsBase
    {
        public override void Display()
        {
            Console.WriteLine("small, but fast");
        }

        public SmallWarrior()
        {
            iattack = new FastAttack();
            irun = new CowardRun();
        }
    }
}
