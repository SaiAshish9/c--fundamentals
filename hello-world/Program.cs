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
            string y = "xy";
            var v = 'x';
            const float c = 1;
            Console.WriteLine("{0} {1}", x, c);
            Console.WriteLine(y);
            Console.WriteLine(v);
            Console.WriteLine("Hello World!");
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);


            string s = "1";
            int i = Convert.ToInt32(s);
            // ToInt16 ToByte ToInt64 ToBoolean
            int j = int.Parse(s);
            // int 32 -> int 8*4
            Console.WriteLine("{0} {1} {2}", s, i, j);

            try
            {
                var num = "a121";
                byte b = Convert.ToByte(num);
                // string str = "true";
                // bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("number could not be converted to a byte");
            }

        }




    }
}
