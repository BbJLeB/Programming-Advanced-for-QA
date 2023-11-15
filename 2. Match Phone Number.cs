    using System;
    using System.Text.RegularExpressions;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\+359([ -])2\1\d{3}([ -])\d{4}\b";

            var matches = Regex.Matches(input, pattern)
                .Cast<Match>()
                .Select(match => match.Value)
                .ToArray();

            Console.WriteLine(string.Join(", ", matches));
        }
    }
