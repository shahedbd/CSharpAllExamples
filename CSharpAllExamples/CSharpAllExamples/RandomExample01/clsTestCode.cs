using System;

namespace CSharpAllExamples.RandomExample01
{
    public static class clsTestCode
    {
        public static int SUM(int x, int y)
        {
            return x + y;
        }
    }



    public class CommonExam
    {
        static string s;
        static DateTime dt;

        void StringTest()
        {
            Console.WriteLine(s == null ? "null" : s);
            Console.WriteLine(dt == null ? "null" : dt.ToString());
        }
    }



    //explicit type casting
    //A a = new B();
    //B b = new A();
    public class A
    {

    }
    public class B : A
    {
    }


    class Fun<T>
    {
        protected T x;
    }


    class MyFun<T> : Fun<T>
    {
        static void F()
        {
            MyFun<T> dt = new MyFun<T>();
            MyFun<int> di = new MyFun<int>();

            MyFun<string> ds = new MyFun<string>();

            dt.x = default(T);
            di.x = 76;
            ds.x = "fun";


        }
    }


    interface IInterface
    {
        void A();
        void B(int a, int b);
        void C(ref int a);

        int AA();
    }


}
