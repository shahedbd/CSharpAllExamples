using System;

namespace CSharpAllExamples.RandomExample01
{
    public static class LambdaExpressions
    {
        delegate int del(int i);
        public static void LambdaHello()
        {
            del myDelegate = x => x * x;
            int j = myDelegate(5); //j = 25
            Console.WriteLine("Value of Num: {0}", j);
        }
    }
}
