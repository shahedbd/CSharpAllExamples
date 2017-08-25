delegate T NumberChanger<T>(T n);

namespace CSharpAllExamples.Examples
{
    public class DelegatesGeneric
    {
        static int num = 10;
        public int AddNum(int p)
        {
            num = num + p;
            return num;
        }

        public int MultNum(int q)
        {
            num = num * q;
            return num;
        }
        public int getNum()
        {
            return num;
        }
    }
}
