using Patterns.NewTest.Ducks;
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

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Duck();
            }

            Console.ReadKey();
        }
    }
}
