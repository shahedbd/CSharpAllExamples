using System;

namespace CSharpAllExamples.Examples
{
    public class ArrayAtoZ
    {
        public ArrayAtoZ()
        {
            Console.WriteLine();
        }




        static void ArrayDetails()
        {
            // Single-dimensional array
            int[] numbers = new int[5];

            // Multidimensional array
            string[,] names = new string[5, 4];

            // Array-of-arrays (jagged array)
            byte[][] scores = new byte[5][];

            // Create the jagged array
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new byte[i + 3];
            }

            // Print length of each row
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
            }

            //Single - Dimensional Array
            int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };
            string[] names2 = new string[3] { "Matt", "Joanne", "Robert" };

            //You can omit the size of the array, like this:
            int[] numbers3 = new int[] { 1, 2, 3, 4, 5 };
            string[] names3 = new string[] { "Matt", "Joanne", "Robert" };

            //You can also omit the new operator if an initializer is provided, like this:
            int[] numbers4 = { 1, 2, 3, 4, 5 };
            string[] names4 = { "Matt", "Joanne", "Robert" };

            //Multidimensional Array
            int[,] numbers5 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            string[,] siblings = new string[2, 2] { { "Mike", "Amy" }, { "Mary", "Albert" } };

            //Using foreach on Arrays
            int[] numbers6 = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
            foreach (int i in numbers)
            {
                System.Console.WriteLine(i);
            }



        }
    }
}
