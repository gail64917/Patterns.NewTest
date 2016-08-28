using Patterns.NewTest.Ducks;
using Patterns.NewTest.FlyExamples;
using Patterns.NewTest.QuackExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.NewTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DuckBase> ducks = new List<DuckBase>();
            ducks.Add(new ExoticDuck());
            ducks.Add(new SimpleDuck());
            ducks.Add(new WoodenDuck());
            ducks.Add(new RubberDuck());

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                duck.Fly();

                Console.WriteLine("_");
            }

            DuckBase upgradableDuck = new UpgradableDuck();
            upgradableDuck.Display();
            upgradableDuck.Swim();
            upgradableDuck.SetFlyBehaviour(new WingFly());
            upgradableDuck.SetQuackBehaviour(new ExoticQuack());
            upgradableDuck.Quack();
            upgradableDuck.Fly();

            Console.ReadKey();
        }
    }
}
