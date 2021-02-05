using System;

namespace strings_enum_reference_types
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "abc";
            Console.WriteLine(string.Format("{0}", x));
            char c = x[0];
            Console.WriteLine(c);
            var num = new int[3] { 1, 2, 3 };
            Console.WriteLine(string.Join(",", num));

            // strings are immutable

            string path = "c:\\projects\\proect1\\folder1";
            Console.WriteLine(path);
            Console.WriteLine("{0} {1}", A.b, (int)A.b);
            var d = 1;
            Console.WriteLine((A)d);
            Console.WriteLine(d.ToString());
            Console.WriteLine((A)Enum.Parse(typeof(A),"a"));
        }
        public enum A
        {
            a = 1,
            b = 2,
            c = 3
        }




    }
}
