namespace CSharpAllExamples.RandomExample01
{

    //The this keyword refers to the current instance of the class 
    //and is also used as a modifier of the first parameter of an extension method.

    class thisEXM
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public thisEXM(string fname, string lname)
        {
            FName = fname;
            LName = lname;
        }
    }
}



/*
There are several usages of this keyword in C#.

To qualify members hidden by similar name
To have an object pass itself as a parameter to other methods
To have an object return itself from a method
To declare indexers
To declare extension methods
To pass parameters between constructors
To internally reassign value type (struct) value.
To invoke an extension method on the current instance
To cast itself to another type
To chain constructors defined in the same class
*/






