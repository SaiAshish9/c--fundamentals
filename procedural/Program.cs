using System;
using System.Collections.Generic;

namespace procedural
{
    class Program
    {
        // procedural programming
        // A programming paradigm based on procedure calls
        // oops 
        // || on objects

        static void Main(string[] args)
        {
            System.Console.WriteLine("name?");
            var name = Console.ReadLine();
            System.Console.WriteLine(ReversedName(name));
            var numbers = new List<int>();
            System.Console.WriteLine("Enter a number : or q");
            while (true)
            {
                var inp = Console.ReadLine();
                if (inp.ToLower() == "q")
                    break;
                numbers.Add(Convert.ToInt32(inp));
            }

            var uniques = GetUniqueNumbers(numbers);

            foreach (var n in uniques)
            {
                System.Console.WriteLine(n);
            }

        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var n in numbers)
            {
                if (!uniques.Contains(n))
                    uniques.Add(n);
            }
            return uniques;

        }


        public static string ReversedName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
            {
                array[name.Length - i] = name[i - 1];
            }
            return new string(array);
        }


    }
}
