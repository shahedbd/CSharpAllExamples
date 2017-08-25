using System;



namespace CSharpAllExamples.Examples.RandomExample01
{
    class OutTestIMP
    {
        public static void ExeOutTestIMP()
        {
            /* local variable definition */
            int a = 100;

            Console.WriteLine("Before method call, value of a : {0}", a);

            /* calling a function to get the value */
            NumberManipulator.getValue(out a);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.ReadLine();
        }
    }

    class NumberManipulator
    {
        public static void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
    }
}
