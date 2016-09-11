using PatternStrategy2.AttackExamples;
using PatternStrategy2.Interfaces;
using PatternStrategy2.RunExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy2.Warriors
{
    public abstract class WarriorsBase
    {
        protected IAttack iattack;
        protected IRun irun;

        public abstract void Display();

        public WarriorsBase()
        {
            irun = new NoRun();
            iattack = new DefaultAttack();
        }

        public void SetAttack(IAttack newAttack)
        {
            iattack = newAttack;
        }

        public void SetRun(IRun newRun)
        {
            irun = newRun;
        }

        public void Attack()
        {
            iattack.Attack();
        }

        public void Run()
        {
            irun.Run();
        }
    }
}
