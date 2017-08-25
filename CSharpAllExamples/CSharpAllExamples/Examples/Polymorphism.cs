using System;

namespace CSharpAllExamples.Examples
{
    class Polymorphism
    {
    }

    //Overloading
    public class OverloadingTest
    {
        public int sumStuff(int x, int y)
        {
            return x + y;
        }
        public float sumStuff(float x, float y)
        {
            return x + y;
        }
    }


    //Overriding 
    public class ParrentClass
    {
        public virtual void print()
        {
            Console.WriteLine("Parent Method");
        }
    }

    public class ChildClass : ParrentClass
    {
        public void child()
        {
            Console.WriteLine("Child Method");
        }

        public override void print()
        {
            Console.WriteLine("Overriding child method");
        }
    }


}





//Overloading = Multiple method signatures, same method name
//Overriding = Same method signature (declared virtual), implemented in sub classes
