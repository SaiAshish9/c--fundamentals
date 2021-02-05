using System;
using oops.Math;

namespace oops
{

    // Right Click Move To Person.cs
    class Program
    {
        static void Main(string[] args)
        {
            Person sai = new Person();
            sai.FirstName = "Sai";
            sai.LastName = "Ashish";
            sai.Introduce();

            Calculator c = new Calculator();

            Console.WriteLine(Calculator.Add(2, 3));

        }
    }
}
