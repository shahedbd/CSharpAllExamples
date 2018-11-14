using System;

namespace CSharpAllExamples.OOP.Polymorphism.MethodOverriding
{
    class clsChild: ParentClass
    {
        public override void Display()
        {
            Console.WriteLine("Child Class: Display");
        }
    }
}
