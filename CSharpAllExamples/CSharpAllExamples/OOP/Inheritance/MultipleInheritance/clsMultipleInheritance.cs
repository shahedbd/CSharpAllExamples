using System;

namespace CSharpAllExamples.OOP.Inheritance.MultipleInheritance
{
    public static class clsMultipleInheritance
    {
        public static void MultipleInheritanceRun()
        {
            Rectangle Rect = new Rectangle();
            int area;
            Rect.setWidth(5);
            Rect.setHeight(7);
            area = Rect.getArea();

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.WriteLine("Total paint cost: ${0}", Rect.getCost(area));
        }
    }
}
