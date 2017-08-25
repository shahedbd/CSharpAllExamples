namespace CSharpAllExamples.Examples
{
    public class SummSubtMulDivFunctions
    {
        public int Summation(int x, int y)
        {
            return x + y;
        }

        public int Subtraction(int x, int y)
        {
            if (x < y) return y - x;
            return x - y;
        }

        public int Multiplication(int x, int y)
        {
            return x * y;
        }

        public long Division(long x, long y)
        {
            if (x < y) return y / x;
            return x / y;
        }
    }
}
