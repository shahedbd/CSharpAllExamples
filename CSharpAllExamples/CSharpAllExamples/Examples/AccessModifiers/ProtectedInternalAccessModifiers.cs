using System;


namespace CSharpAllExamples.Examples.AccessModifiers
{
    public static class ProtectedInternalAccessModifiers 
    {
        public static void ExeProtectedInternalAccessModifiers()
        {
            access ac = new access();
            Console.Write("Enter your name: ");
            // Accepting value in protected internal variable
            ac.name = Console.ReadLine();
            ac.print();
            Console.ReadLine();
        }
    }

    class access
    {
        // String Variable declared as protected internal
        protected internal string name;
        public void print()
        {
            Console.WriteLine("\nMy name is:" + name);
        }
    }

}
