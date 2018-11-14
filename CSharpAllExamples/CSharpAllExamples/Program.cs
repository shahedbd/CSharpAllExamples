using CSharpAllExamples.Examples;
using CSharpAllExamples.OOP.Abstraction;
using CSharpAllExamples.OOP.Interfaces;
using CSharpAllExamples.RandomExample01.PassingParameters;
using System;
using System.Reflection;

namespace CSharpAllExamples
{
    class Program
    {

        static void Main(string[] args)
        {
            //ParametersTypes.IMPParametersTypesOUTOnly();
            ImplementingReflection2();

            //AbstractionIMP.AbstractionRun();
            //clsMultipleInheritance.MultipleInheritanceRun();
            //clsInheritance.InheritanceExampleRun();
            //ParametersTypes.IMPParametersTypesOUTOnly();
            //ParametersTypes.IMPParametersTypes();

            //LazyLoadingPatternTest2 _LazyLoadingPatternTest2 = new LazyLoadingPatternTest2();
            //_LazyLoadingPatternTest2.IMPLazyLoadingPattern();

            //IMPAbstractClass.EXEAbtructAction();
            //StructExamples.StructIMP();
            //ImplementAbtructClass();

            //AnonymousTypes oAnonymousTypes = new AnonymousTypes();
            //oAnonymousTypes.TestAnonType();


            //ImplementInterface();
            //ImplementInterface2();
            //ImplementDelegate3();

            //ImplementingGenericArray();
            //ImplementingGenericMethods();

            //ImplementingReflection2();

            //ImplementingExtensionMethods();

            //ImplementingEnum();

            //ImplementOverriding();


            //PartialAndStaticClassIMP();
            //OverrideExe();

            //TemperatureConverter.StatitClassIMP();

            //AbstractIMP();

            //AwaitAndAsync.MyMethodAsync();

            //PublicAccessModifiers.ExePublicAccessModifiers();
            //PrivateAccessModifiers.ExePrivateAccessModifiers();


            //ProtectedInternalAccessModifiers.ExeProtectedInternalAccessModifiers();

            //DelegateTest.ImplementDelegate();

            //LambdaExpressions.LambdaHello();

            Console.ReadKey();
        }


        static void ImplementingEnum()
        {
            int WeekdayStart = (int)EnumTest.Days.Mon;
            int WeekdayEnd = (int)EnumTest.Days.Fri;
            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
            Console.ReadKey();
        }

        static void ImplementingExtensionMethods()
        {
            string userSentance = string.Empty;
            int totalWords = 0;
            int totalCharWithoutSpace = 0;
            Console.WriteLine("Enter the your sentance");
            userSentance = Console.ReadLine();
            //calling Extension Method WordCount
            totalWords = userSentance.WordCount();


            Console.WriteLine("Total number of words is :" + totalWords);
            //calling Extension Method to count character
            totalCharWithoutSpace = userSentance.TotalCharWithoutSpace();
            Console.WriteLine("Total number of character is :" + totalCharWithoutSpace);
            Console.ReadKey();
        }


        static void ImplementingReflection2()
        {
            MemberInfo info = typeof(ReflectionTestCls);
            object[] attributes = info.GetCustomAttributes(true);
            //for (int i = 0; i < attributes.Length; i++)
            //{
            //    Console.WriteLine(attributes[i]);
            //}

            foreach (var item in attributes)
            {
                Console.WriteLine(item);
            }

        }


        static void ImplementingReflection1()
        {
            SummSubtMulDivFunctions oSummSubtMulDivFunctions = new SummSubtMulDivFunctions();

            //Get the Type information.
            Type myTypeObj = oSummSubtMulDivFunctions.GetType();

            // Get Method Information.
            MethodInfo myMethodInfo = myTypeObj.GetMethod("Summation");
            object[] mParam = new object[] { 5, 10 };
            // Get and display the Invoke method.
            Console.Write("\nFirst method - " + myTypeObj.FullName + " returns " +
                                 myMethodInfo.Invoke(oSummSubtMulDivFunctions, mParam) + "\n");

        }


        static void ImplementingGenericMethods()
        {
            GenericMethods oGenericMethods = new GenericMethods();
            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            //display values before swap:
            Console.WriteLine("Int values before calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values before calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);

            //call swap
            oGenericMethods.Swap<int>(ref a, ref b);
            oGenericMethods.Swap<char>(ref c, ref d);

            //display values after swap:
            Console.WriteLine("Int values after calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values after calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);
        }



        static void ImplementingGenericArray()
        {
            //declaring an int array
            GenericArray<int> oGenericArrayInt = new GenericArray<int>(5);

            //setting values
            for (int c = 0; c < 5; c++)
            {
                oGenericArrayInt.setItem(c, c * 5);
            }

            //retrieving the values
            for (int c = 0; c < 5; c++)
            {
                Console.Write(oGenericArrayInt.getItem(c) + " ");
            }

            //declaring a character array
            GenericArray<char> oGenericArrayChar = new GenericArray<char>(5);

            //setting values
            for (int c = 0; c < 5; c++)
            {
                oGenericArrayChar.setItem(c, (char)(c + 97));
            }

            //retrieving the values
            for (int c = 0; c < 5; c++)
            {
                Console.Write(oGenericArrayChar.getItem(c) + " ");
            }
        }

        static void ImplementDelegate3()
        {
            DelegatesGeneric oDelegatesGeneric = new DelegatesGeneric();
            //create delegate instances
            NumberChanger<int> nc1 = new NumberChanger<int>(oDelegatesGeneric.AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(oDelegatesGeneric.MultNum);

            //calling the methods using the delegate objects
            nc1(25);
            Console.WriteLine("Value of Num: {0}", oDelegatesGeneric.getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", oDelegatesGeneric.getNum());
        }


        static void ImplementDelegate2()
        {
            DelegateUse oDelegateUse = new DelegateUse();
            PrintString ps1 = new PrintString(oDelegateUse.WriteToScreen);
            PrintString ps2 = new PrintString(oDelegateUse.WriteToFile);

            oDelegateUse.sendString(ps1);
            oDelegateUse.sendString(ps2);
        }



        static void ImplementInterface()
        {
            Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
            Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);
            t1.showTransaction();
            t2.showTransaction();
            Console.ReadKey();
        }

        static void ImplementInterface2()
        {
            Console.WriteLine("This is ODD");
            IFive obj1 = new ODDEVEN();
            obj1.ONE();
            obj1.THREE();
            obj1.FIVE();


            Console.WriteLine("\n\nThis is EVEN");
            IEVEN obj2 = new ODDEVEN();
            obj2.TWO();
            obj2.FOUR();
        }


        static void ImplementOverriding()
        {
            ParrentClass oParrentClass = new ParrentClass();
            ChildClass oChildClass = new ChildClass();
            oParrentClass.print();
            oChildClass.print();
        }



    }
}

