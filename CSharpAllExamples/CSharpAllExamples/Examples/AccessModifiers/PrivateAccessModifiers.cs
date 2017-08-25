﻿using System;

namespace CSharpAllExamples.Examples.AccessModifiers
{
    public static class PrivateAccessModifiers
    {
        public static void ExePrivateAccessModifiers()
        {
            RectanglePrivateTest r = new RectanglePrivateTest();
            r.Acceptdetails();
            r.Display();

            //var abc = r.length    //Not accesbale due to private
            Console.ReadLine();
        }
    }
    class RectanglePrivateTest
    {
        //member variables
        private double length;
        private double width;

        public void Acceptdetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }
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
