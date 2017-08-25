using System;

namespace Test.DLL.Project.Examples
{
    class InternalAccessModifiers
    {
        static void ExeInternalAccessModifiers()
        {
            RectangleInternalTestFromOtherDLL r = new RectangleInternalTestFromOtherDLL();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();

            var abc = r.length;     //Accesbale due to internal: current assembly.

            Console.ReadLine();
        }
    }

    public class RectangleInternalTestFromOtherDLL
    {
        //member variables
        internal double length;
        internal double width;

        double GetArea()
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
