using System;
using Test.DLL.Project.Examples;

namespace CSharpAllExamples.Examples.AccessModifiers
{
    class InternalAccessModifiers
    {
        static void ExeInternalAccessModifiers()
        {
            RectangleInternalTest r = new RectangleInternalTest();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();

            var abc = r.length;     //Accesbale due to internal: current assembly.

            RectangleInternalTestFromOtherDLL oRectangleInternalTestFromOtherDLL = new RectangleInternalTestFromOtherDLL();
            //var abc2 = oRectangleInternalTestFromOtherDLL.length;       ////Not Accesbale due to internal: Other assembly.

            Console.ReadLine();
        }
    }

    class RectangleInternalTest
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
