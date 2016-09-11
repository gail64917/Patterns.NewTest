using PatternStrategy2.AttackExamples;
using PatternStrategy2.RunExamples;
using PatternStrategy2.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<WarriorsBase> warriors = new List<WarriorsBase>();
            warriors.Add(new BigWarrior());
            warriors.Add(new SmallWarrior());

            foreach (var warrior in warriors)
            {
                warrior.Display();
                warrior.Run();
                warrior.Attack();

                Console.WriteLine("______________");
            }

            Console.WriteLine("______________");
            Console.WriteLine("old big war");

            WarriorsBase bigWar = new BigWarrior();
            bigWar.Run();
            bigWar.Attack();

            bigWar.SetAttack(new FastAttack());
            bigWar.SetRun(new CowardRun());

            Console.WriteLine("______________");
            Console.WriteLine("new big war");

            bigWar.Attack();
            bigWar.Run();

            Console.ReadKey();
        }
    }
}
