using Patterns.NewTest.FlyExamples;
using Patterns.NewTest.Interfaces;
using Patterns.NewTest.QuackExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.NewTest.Ducks
{
    public abstract class DuckBase
    {
        protected IFlyable flyBehaviour;
        protected IQuackable quackBehaviour;

        public abstract void Display();

        public DuckBase()
        {
            flyBehaviour = new WingFly();
            quackBehaviour = new SimpleQuack();
        }

        public void SetQuackBehaviour(IQuackable newQuackBehaviour)
        {
            quackBehaviour = newQuackBehaviour;
        }

        public void SetFlyBehaviour(IFlyable newFlyBehaviour)
        {
            flyBehaviour = newFlyBehaviour;
        }

        public void Swim()
        {
            Console.WriteLine("SWIMING-SWIMING");
        }

        public void Quack()
        {
            quackBehaviour.Quack();
        }

        public void Fly()
        {
            flyBehaviour.Fly();
        }
    }
}
