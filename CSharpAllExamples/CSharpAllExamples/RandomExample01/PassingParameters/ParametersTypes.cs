using System;

namespace CSharpAllExamples.RandomExample01.PassingParameters
{
    public class ParametersTypes
    {

        public static void IMPParametersTypes()
        {
            int arg;

            // Passing by value.
            // The value of arg in IMP method is not changed.
            arg = 4;
            squareValParameter(arg);
            Console.WriteLine(arg);
            // Output: 4

            // Passing by reference.
            // The value of arg in IMP method is changed.
            arg = 4;
            squareRefParameter(ref arg);
            Console.WriteLine(arg);


            //var A1 = squareValParameterRet(arg);
            //var A2 = squareRefParameterRet(ref arg);


        }


        public static void IMPParametersTypesOUTOnly()
        {
            /* local variable definition */
            int a = 100;

            Console.WriteLine("Before method call, value of a : {0}", a);

            /* calling a function to get the value */
            getValue(out a);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.ReadLine();
        }


        static void squareValParameter(int valParameter)
        {
            valParameter *= valParameter;
        }

        // Passing by reference
        static void squareRefParameter(ref int refParameter)
        {
            refParameter *= refParameter;
        }


        //Out PRM
        public static void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }



        //static int squareValParameterRet(int valParameter)
        //{
        //    return valParameter *= valParameter;
        //}

        //static int squareRefParameterRet(ref int refParameter)
        //{
        //    return refParameter *= refParameter;
        //}
    }
}
