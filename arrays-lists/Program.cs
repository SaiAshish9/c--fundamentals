using System;
using System.Collections.Generic;

namespace arrays_lists
{
    class Program
    {

        static void print(List<int> numbers)
        {
            foreach (var i in numbers)
            {
                System.Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {

            // jagged array

            var x = new int[3][];

            // rectangular array

            x[0] = new int[3] { 1, 2, 3 };

            System.Console.WriteLine(x[0][1]);

            var y = new int[3, 2]{
                {1,2},
                {2,4},
                {5,6}
            };

            System.Console.WriteLine(y[0, 0]);

            //  lists



            var numbers = new List<int>();
            numbers.Add(1);
            numbers.AddRange(new int[3] { 1, 2, 3 });


            print(numbers);

            System.Console.WriteLine("{0} {1} {2}",
            numbers.IndexOf(1),
            numbers.Count,
            numbers.LastIndexOf(1)
            );


            numbers.Remove(1);

            print(numbers);

            numbers.Clear();

            print(numbers);


        }
    }
}
