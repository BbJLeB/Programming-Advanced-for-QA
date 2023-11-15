using System;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

        var matches = Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(match => match.Value)
            .ToArray();

        Console.WriteLine(string.Join(" ", matches));
    }
}
