﻿namespace CSharpAllExamples.Examples
{
    public class GenericMethods
    {
        public void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
