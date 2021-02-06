using System;
using System.Collections.Generic;

namespace text
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullname = "Sai Ashish ";
            System.Console.WriteLine("Trim : '{0}'", fullname.Trim());
            System.Console.WriteLine("ToUpper: '{0}'", fullname.Trim().ToUpper());

            var index = fullname.IndexOf(' ');
            var firstname = fullname.Substring(0, index);
            var lastname = fullname.Substring(index + 1);
            System.Console.WriteLine("{0} {1}", firstname, lastname);

            var names = fullname.Split(' ');
            System.Console.WriteLine(names[0]);

            fullname.Replace("Sai", "SAI");
            fullname.Replace("Ashish", "ASHISH");

            if (String.IsNullOrEmpty(null))
            {
                System.Console.WriteLine("Invalid");
            }

            var str = "25";
            System.Console.WriteLine(Convert.ToByte(str));
            float price = 29.5f;
            System.Console.WriteLine(price.ToString("C"));


            var sentence = "This is going yo be a long text.";

            System.Console.WriteLine(SummarizeText(sentence));
        }

        static string SummarizeText(string sentence)
        {
            const int maxLength = 20;
            var summaryWords = new List<string>();

            if (sentence.Length < maxLength)
            {
                System.Console.WriteLine(sentence);
            }
            else
            {
                var words = sentence.Split(' ');
                var totalChars = 0;

                foreach (var x in words)
                {
                    summaryWords.Add(x);

                    totalChars += x.Length + 1;
                    if (totalChars > maxLength)
                        break;
                }

            }
            return String.Join(" ", summaryWords) + "...";

        }
    }
}
