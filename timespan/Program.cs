using System;

namespace timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            var ts = new TimeSpan(1, 2, 3);
            // 1h 2m 3s

            var ts1 = new TimeSpan(1, 0, 0);
            
            // 1h 0m 0s
            
            var ts2 = TimeSpan.FromHours(1);
            // 1h 0m 0s

            System.Console.WriteLine("Duration : " + (DateTime.Now.AddMinutes(3) - DateTime.Now));
            System.Console.WriteLine(ts.Minutes);
            System.Console.WriteLine(ts.TotalMinutes);
            System.Console.WriteLine(ts.Add(TimeSpan.FromMinutes(8)));
            System.Console.WriteLine(ts.Subtract(TimeSpan.FromMinutes(8)));


        }
    }
}
