using System;

namespace CSharpAllExamples.OOP.Inheritance
{
    public static class clsInheritance
    {
        public static void InheritanceExampleRun()
        {
            DerivedClass _derivedClass = new DerivedClass();
            _derivedClass.BasePrint();
            _derivedClass.DrivedPrint();
        }
    }


    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Base Constructor.");
        }

        public void BasePrint()
        {
            Console.WriteLine("Hello from Base Class.");
        }
    }

    public class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("Derived Constructor.");
        }

        public void DrivedPrint()
        {
            Console.WriteLine("Hello from Drives Class.");
        }
    }

}
