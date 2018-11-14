namespace CSharpAllExamples.Examples
{

    public class OverloadingTest
    {
        public int sumStuff(int x, int y)
        {
            return x + y;
        }
        public double sumStuff(double x, double y)
        {
            return x + y;
        }

        public int sumStuff(int x, int y, int z)
        {
            return x + y + z;
        }
    }

}





//Overloading = Multiple method signatures, same method name
//Overriding = Same method signature (declared virtual), implemented in sub classes
