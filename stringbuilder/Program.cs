using System;
using System.Text;

namespace stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // mutable string
            // Append Insert Remove Replace Clear  

            var builder = new StringBuilder("hi");
            builder.Append('-', 10)
            .AppendLine()
            .Append("hi");
            System.Console.WriteLine(builder);
            builder.Replace('-', '+')
            .Remove(2, 13);
            System.Console.WriteLine(builder);
            builder.Insert(0, new string('-', 10));
            System.Console.WriteLine(builder);
        }
    }
}
