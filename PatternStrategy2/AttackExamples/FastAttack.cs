using PatternStrategy2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy2.AttackExamples
{
    class FastAttack : IAttack
    {
        public void Attack()
        {
            Console.WriteLine("Faster than light");
        }
    }
}
