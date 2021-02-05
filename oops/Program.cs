using System;
using oops.Math;

namespace oops
{

    // Right Click Move To Person.cs

    public struct Color
    {
        public int Red;
        public int Blue;
    }



    class Program
    {
        static void Main(string[] args)
        {
            Person sai = new Person();
            sai.FirstName = "Sai";
            sai.LastName = "Ashish";
            sai.Introduce();

            Calculator c = new Calculator();
            Color x = new Color();
            // Initializes to default value 0
            Color y;
            y.Red = 10;
            Console.WriteLine("{0} {1}", x.Red, y.Red);

            Console.WriteLine(Calculator.Add(2, 3));

        }
    }
}

// Structs are value 
// types and are copied on assignment. 
// Structs are value types while classes 
// are reference types. 
// Structs can be instantiated without using a new operator. A struct cannot inherit from another struct

/*
 S.N	 Struct	 Classes
 1	 Structs are value types, allocated either on the stack or inline in containing types.	Classes are reference types, allocated on the heap and garbage-collected. 
 2 	 Allocations and de-allocations of value types are in general cheaper than allocations and de-allocations of reference types.	 Assignments of large reference types are cheaper than assignments of large value types.
 3	In structs, each variable contains its own copy of the data (except in the case of the ref and out parameter variables), and an operation on one variable does not affect another variable.
 In classes, two variables can contain the reference of the same object and any operation on one variable can affect another variable.
*/