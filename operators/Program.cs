using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            var x = new bool[3]{true,false,true};
            int[] y=new int[3];
            y[0]=4;
            Console.WriteLine("{0}",y[0],y[2]);
            Console.WriteLine((float)a / (float)b);
            Console.WriteLine("{0} {1} {2}", a == b, a != b, a == b);
            Console.WriteLine(a > b || a == b);
            Console.WriteLine(a | b);
            // 
            /* a=10;
            a=11; */
        }
    }
}
