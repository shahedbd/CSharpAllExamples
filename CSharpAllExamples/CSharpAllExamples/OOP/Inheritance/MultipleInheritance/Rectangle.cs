namespace CSharpAllExamples.OOP.Inheritance.MultipleInheritance
{
    class Rectangle : Shape, IPaintCost
    {
        public int getArea()
        {
            return (width * height);
        }

        public int getCost(int area)
        {
            return area * 70;
        }
    }
}
