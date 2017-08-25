using System;

namespace CSharpAllExamples.Examples.Abstraction
{
    class AbstractTest
    {
    }

    abstract class IMyAnimal
    {
        public abstract void Eat();
        public void Sound()
        {
            Console.WriteLine("Dog can sound!");
        }
    }

    class MyDog : IMyAnimal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog can eat!");
        }
    }
}
