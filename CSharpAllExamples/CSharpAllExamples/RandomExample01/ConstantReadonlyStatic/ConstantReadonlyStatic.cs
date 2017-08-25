using System;

namespace CSharpAllExamples.RandomExample01.ConstantReadonlyStatic
{
    class ConstantReadonlyStatic
    {
    }


    class clsConstant
    {
        void Sum(int j)
        {
            const int i = 9, k = 2;
            const int A = i + k;
        }

        void Sum2(int j)
        {
            const int i = 9, k = 2;
            //const int A = i + k;
            //const int B = i + j; // a compile-time error, because there is no initialization, since it's evaluated at run time.
        }
    }


    class clsReadOnly
    {
        readonly int _year;
        clsReadOnly(int year)
        {
            _year = year;
        }
        void ChangeYear()
        {
            //_year = 1967; // Compile error if uncommented.
        }
    }

    class clsReadOnly2
    {
        readonly int i;
        public clsReadOnly2()
        {
            i = 11;
            Console.WriteLine(i);
        }
    }


    class clsStatic
    {
        static int i = 11;
        public static void disp()
        {
            Console.WriteLine(i);
        }
    }


    class clsStatic2
    {
        int i = 9;
        public static void disp()
        {
            //Console.WriteLine(i); //error, because we didn't declare a value for the static and we are trying to access it within a method. We can't do that.
        }
    }


}
