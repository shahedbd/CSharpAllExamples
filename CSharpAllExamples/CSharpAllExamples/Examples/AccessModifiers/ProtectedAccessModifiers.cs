﻿namespace CSharpAllExamples.Examples.AccessModifiers
{
    class ProtectedAccessModifiers
    {
    }

    class ClassTest
    {
        //Protected variable
        protected int _a;
    }

    class ClassTest2 : ClassTest
    {
        ClassTest2()
        {
            this._a = 10; // can access from this class
        }
    }

    class ClassTest3
    {
        ClassTest3()
        {
            //this._a = 10; // can't access from this class
        }
    }
}
