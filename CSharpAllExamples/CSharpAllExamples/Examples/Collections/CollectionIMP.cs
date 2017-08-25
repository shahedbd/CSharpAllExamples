using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpAllExamples.Examples.Collections
{
    class CollectionIMP
    {
        //Non-generic Collections: using System.Collections;
        public static void ArrayList()
        {
            ArrayList al = new ArrayList();

            Console.WriteLine("Adding some numbers:");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);

            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);

            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
        }

        public static void Hashtable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable[1] = "One";
            hashtable[2] = "Two";
            hashtable[13] = "Thirteen";
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }


            Hashtable ht = new Hashtable();
            ht.Add("001", "Zara Ali");
            ht.Add("002", "Abida Rehman");
            ht.Add("003", "Joe Holzner");
            ht.Add("004", "Mausam Benazir Nur");
            ht.Add("005", "M. Amlan");
            ht.Add("006", "M. Arif");
            ht.Add("007", "Ritesh Saikia");
            if (ht.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("008", "Nuha Ali");
            }

            // Get a collection of the keys.
            ICollection key = ht.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }

        }

        //A sorted list is a combination of an array and a hash table.
        public static void SortedList()
        {
            SortedList sl = new SortedList();

            sl.Add("001", "Zara Ali");
            sl.Add("002", "Abida Rehman");
            sl.Add("003", "Joe Holzner");
            sl.Add("004", "Mausam Benazir Nur");
            sl.Add("005", "M. Amlan");
            sl.Add("006", "M. Arif");
            sl.Add("007", "Ritesh Saikia");

            if (sl.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                sl.Add("008", "Nuha Ali");
            }

            // get a collection of the keys. 
            ICollection key = sl.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }
        }

        public static void StackIMP()
        {
            Stack st = new Stack();

            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            st.Push('V');
            st.Push('H');
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing values ");
            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
        }

        public static void QueueIMP()
        {
            Queue q = new Queue();

            q.Enqueue('A');
            q.Enqueue('M');
            q.Enqueue('G');
            q.Enqueue('W');

            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " ");

            Console.WriteLine();
            q.Enqueue('V');
            q.Enqueue('H');
            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " ");

            Console.WriteLine();
            Console.WriteLine("Removing some values ");
            char ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
        }


        //Generic Collections: using System.Collections.Generic;
        public static void ListIMP()
        {

            IList<int> intList = new List<int>() { 10, 20, 30, 40 };


            List<string> authors = new List<string>();

            Console.WriteLine("\nCapacity: {0}", authors.Capacity);

            authors.Add("Mahesh Chand");
            authors.Add("Joseph Talmadge");
            authors.Add("Raj Kumar");
            authors.Add("Dinesh Beniwal");
            authors.Add("Praveen Jacobs");

            Console.WriteLine();
            foreach (string author in authors)
            {
                Console.WriteLine(author);
            }

            Console.WriteLine("Number of Authors in List: {0}", authors.Count);

            Console.WriteLine("\nContains(\"Author\"): {0}",
                authors.Contains("Praveen Jacobs"));

            Console.WriteLine("\nInsert(2, \"Raj Kumar\")");
            authors.Insert(2, "Jacobs Mark");

            Console.WriteLine();
            foreach (string author in authors)
            {
                Console.WriteLine(author);
            }

            Console.WriteLine("\nauthors[3]: {0}", authors[3]);

            Console.WriteLine("\nRemove(\"Raj Kumar\")");
            authors.Remove("Jacobs Mark");

            Console.WriteLine();
            foreach (string author in authors)
            {
                Console.WriteLine(author);
            }

            Console.WriteLine();
            authors.Sort();
            Console.WriteLine("Sorted List");
            foreach (string author in authors)
            {
                Console.WriteLine(author);
            }

            authors.TrimExcess();
            Console.WriteLine("\nTrimExcess()");
            Console.WriteLine("Capacity: {0}", authors.Capacity);
            Console.WriteLine("Count: {0}", authors.Count);

            authors.Clear();
            Console.WriteLine("\nClear()");
            Console.WriteLine("Capacity: {0}", authors.Capacity);
            Console.WriteLine("Count: {0}", authors.Count);
        }


        public static void DictionaryIMP()
        {
            IDictionary<int, string> idict = new Dictionary<int, string>();
            //or
            Dictionary<int, string> dict = new Dictionary<int, string>();


            Dictionary<string, int> oDictionary = new Dictionary<string, int>();
            oDictionary.Add("cat", 2);
            oDictionary.Add("dog", 1);
            oDictionary.Add("llama", 0);
            oDictionary.Add("iguana", -1);

            foreach (KeyValuePair<string, int> author in oDictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", author.Key, author.Value);
            }
        }


    }

}
