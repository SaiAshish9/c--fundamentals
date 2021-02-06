using System;

namespace dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2021, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            var @int= 10;

            System.Console.WriteLine(@int);

            var tom = now.AddDays(1);
            var yes = now.AddDays(-1);

            System.Console.WriteLine(now.ToLongDateString());
            System.Console.WriteLine(now.ToShortDateString());
            System.Console.WriteLine(now.ToLongTimeString());
            System.Console.WriteLine(now.ToShortTimeString());
            System.Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss"));    
            
                    
        }
    }
}
