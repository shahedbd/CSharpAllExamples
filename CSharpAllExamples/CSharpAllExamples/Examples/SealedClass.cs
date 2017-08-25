using System;

namespace CSharpAllExamples.Examples
{
    public class SealedClass
    {

    }


    sealed class A
    {
        private int x = 1;
        public void printA()
        {
            Console.WriteLine(x);
        }
    }

    //cannot derive from sealed type    class B : A
    class B 
    {
        public void print_B()
        {
            A a = new A();
            a.printA();
        }
    }

    class C
    {
        public void print_B()
        {
            A a = new A();
            a.printA();
        }
    }

}



//Notes: In simplest terms, you can't inherit form a sealed class. 
//The sealed keyword literally seals it for further inheritance.
