using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            // decimal a = 1.2m;
            // checked{
            //     byte x =255;
            //     x+=1;
            // }
            char x = 'x';
            string y ="xy";
            var v = 'x';
            const float c = 1;
            Console.WriteLine("{0} {1}",x,c);
            Console.WriteLine(y);
            Console.WriteLine(v);
            Console.WriteLine("Hello World!");
            Console.WriteLine("{0} {1}",int.MinValue,int.MaxValue);
        }
    }
}
