using System;


namespace CSharpAllExamples.OOP.Interfaces
{
    public interface ITransactions
    {
        // interface members
        void showTransaction();
        double getAmount();
    }


    public class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;
        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }

        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }

        public double getAmount()
        {
            return amount;
        }

        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
    }
}



/*An interface contains only the signatures of methods, properties, events or indexers. 
A class or struct that implements the interface must implement the members of the interface 
that are specified in the interface definition. 
In the following example, class ImplementationClass must implement a method named SampleMethod that has no parameters and returns void.

*/
