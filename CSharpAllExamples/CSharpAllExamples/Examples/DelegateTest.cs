using System;

delegate int NumberChanger(int n);
delegate int NumberChanger2(int n1, int n2);

namespace CSharpAllExamples.Examples
{
    public static class DelegateTest
    {

        public static void ImplementDelegate()
        {
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            NumberChanger2 nc3 = new NumberChanger2(SumTwoNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            int x = nc3(5, 5);
            Console.WriteLine("Value of Num: {0}", x);
        }



        static int num = 10;
        public static int AddNum(int p)
        {
            num = num + p;
            return num;
        }

        public static int MultNum(int q)
        {
            num = num * q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

        public static int SumTwoNum(int x, int y)
        {
            num = x + y;
            return num;
        }

    }
}
