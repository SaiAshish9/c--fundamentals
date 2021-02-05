using System;

namespace control_flow
{

    class Program
    {
        static void Main(string[] args)
        {
            if (1 == 1)
            {
            }
            else { }
            switch (Season.A)
            {
                case Season.A:
                    break;
                default:
            }
            for (var i = 0; i < 10; i++)
            {

            }
            var x = new int[] { 1, 2, 3 };
            foreach (var i in x) { }

            var r = new Random();
            var buffer= new char[8];
            for (var i = 0; i < 8; i++)
            {
                buffer[i] = (char)('a'+r.Next(0,26));
                // System.Console.WriteLine(r.Next(1,10));
            }

            var password = new string(buffer);
            System.Console.WriteLine(password); 

            // System.Console.WriteLine((int)'a');


        }
    }
}
