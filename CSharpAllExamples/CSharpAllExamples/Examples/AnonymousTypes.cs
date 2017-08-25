﻿using System;

//The anonymous type declaration starts with the new keyword.

namespace CSharpAllExamples.Examples
{
    public class AnonymousTypes
    {
        public void TestAnonType()
        {
            var v = new { Amount = 108, Message = "Hello" };

            // Rest the mouse pointer over v.Amount and v.Message in the following  
            // statement to verify that their inferred types are int and string.  
            Console.WriteLine(v.Amount + " " +  v.Message);



            var myAnonymousType = new
            {
                firstProperty = "First",
                secondProperty = 2,
                thirdProperty = true
            };

            Console.WriteLine(myAnonymousType.GetType().ToString());


            var anonArray = new[] { new { name = "apple", diam = 4 }, new { name = "grape", diam = 1 } };

            foreach (var item in anonArray)
            {
                Console.WriteLine(item.ToString());
            }


        }
    }
}





/*
Anonymous types provide a convenient way to encapsulate a set of read-only properties 
into a single object without having to explicitly define a type first.
The type name is generated by the compiler and is not available at the source code level.
The type of each property is inferred by the compiler.

You create anonymous types by using the new operator together with an object initializer. 

*/