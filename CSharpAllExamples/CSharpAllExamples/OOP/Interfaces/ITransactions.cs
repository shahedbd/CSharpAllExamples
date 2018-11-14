namespace CSharpAllExamples.OOP.Interfaces
{
    public interface ITransactions
    {
        void showTransaction();
        double getAmount();
    }
   
}



/*An interface contains only the signatures of methods, properties, events or indexers. 
A class or struct that implements the interface must implement the members of the interface 
that are specified in the interface definition. 
In the following example, class ImplementationClass must implement a method named SampleMethod that has no parameters and returns void.

*/
