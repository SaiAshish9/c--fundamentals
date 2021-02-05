using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            Console.WriteLine((float)a / (float)b);
            Console.WriteLine("{0} {1} {2}",a==b,a!=b,a==b);
            Console.WriteLine(a>b || a==b);
            Console.WriteLine(a|b);




        }
    }
}
