using System;

namespace CSharpAllExamples.OOP.Interfaces
{
    public class Transaction : ITransactions
    {
        TransactionModel objTransactionModel = new TransactionModel();
        public Transaction(string c, string d, double a)
        {
            objTransactionModel.TranCode = c;
            objTransactionModel.TranDate = d;
            objTransactionModel.TranAmmount = a;
        }

        public double getAmount()
        {
            return objTransactionModel.TranAmmount * 10;
        }

        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", objTransactionModel.TranCode);
            Console.WriteLine("Date: {0}", objTransactionModel.TranDate);
            Console.WriteLine("Amount: {0}", getAmount());
            Console.WriteLine();
        }
    }
}
