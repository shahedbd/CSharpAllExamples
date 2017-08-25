using System;

namespace CSharpAllExamples.Examples
{


    public class IMPAbstractClass
    {
        public static void EXEAbtructAction()
        {
            //Cannot create an instance of the abstract class or interface
            //AbstractClass oAbstractClass = new AbstractClass();

            //You can create an instance of the derived class
            AbstractClassDerived oAbstractClassDerived = new AbstractClassDerived();
            int added = oAbstractClassDerived.AddTwoNumbers(10, 20);
            int multiplied = oAbstractClassDerived.MultiplyTwoNumbers(10, 20);
            Console.WriteLine("Added : {0}, Multiplied: {1}", added, multiplied);
        }
    }



    abstract class AbstractClass
    {
        //A Non abstract method
        public int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }

        //An abstract method, to be overridden in derived class
        public abstract int MultiplyTwoNumbers(int Num1, int Num2);
    }



    class AbstractClassDerived : AbstractClass
    {
        //using override keyword,implementing the abstract method MultiplyTwoNumbers
        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }


}




/*
 The abstract modifier indicates that the thing being modified has a missing or incomplete implementation. 
 The abstract modifier can be used with classes, methods, properties, indexers, and events. 
 Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes. 
 Members marked as abstract, or included in an abstract class, must be implemented by classes that derive from the abstract class.

An Abstract class is an incomplete class or special class we can't instantiate. 
We can use an Abstract class as a Base Class. 
An Abstract method must be implemented in the non-Abstract class using the override keyword. 
After overriding the abstract method is in the non-Abstract class. 
We can derive this class in another class and again we can override the same abstract method with it. 

Features:
An abstract calss can inherit from a class and one or more interfaces.
An abstract class can implement code with non-Abstract methods.
An Abstract class can have modifiers for methods, properties etc.
An Abstract class can have constants and fields.
An abstract class can implement a property.
An abstract class can have constructors or destructors.
An abstract class cannot be inherited from by structures.
An abstract class cannot support multiple inheritance.


 */
