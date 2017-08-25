using System;

namespace CSharpAllExamples.Examples.AccessModifiers
{
    public static class PublicAccessModifiers
    {
        public static void ExePublicAccessModifiers()
        {
            RectanglePublicTest r = new RectanglePublicTest();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();


            var abc = r.length;     //Accesbale due to public
            Console.ReadLine();
        }
    }

    class RectanglePublicTest
    {
        //member variables
        public double length;
        public double width;

        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }//end class Rectangle

}
