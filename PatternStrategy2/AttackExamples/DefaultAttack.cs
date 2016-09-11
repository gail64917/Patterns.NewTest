using PatternStrategy2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy2.AttackExamples
{
    class DefaultAttack : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("I`ll Attack!");
        }
    }
}
