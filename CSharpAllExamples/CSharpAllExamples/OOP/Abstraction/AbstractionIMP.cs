using System;

namespace CSharpAllExamples.OOP.Abstraction
{
    public static class AbstractionIMP
    {
        public static void AbstractionRun()
        {
            Dog mydog = new Dog();
            Animal thePet = mydog;
            thePet.Eat();
            mydog.Sound();
        }
    }


    abstract class Animal
    {
        public abstract void Eat();
        public void Sound()
        {
            Console.WriteLine("Dog can sound");
        }
    }
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog can eat");
        }
    }



}
