using System;
using System.IO;

namespace directories
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"obj1");
            var files = Directory.GetFiles(@"obj", "*.*", SearchOption.AllDirectories);
            var directories = Directory.GetDirectories(@"obj", "*.*", SearchOption.AllDirectories);
            foreach (var i in files)
            {
                System.Console.WriteLine(i);
            }

            // Directory.Exists("*.*)
            // new DirectoryInfo("...").GetFiles()/.GetDirectories()

            var path = @"C:\Projects\a.sln";

            System.Console.WriteLine(path.IndexOf("."));
            System.Console.WriteLine(
                path.Substring(path.IndexOf("."))
            );
            System.Console.WriteLine(Path.GetExtension(path));
            System.Console.WriteLine(
                Path.GetFileName(path)
            );
            System.Console.WriteLine(
                Path.GetFileNameWithoutExtension(path)
            );
            System.Console.WriteLine(
                Path.GetDirectoryName(path)
            );


        }
    }
}
