using System;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(?<day>\d{2})(?<separator>[./-])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})\b";

        var matches = Regex.Matches(input, pattern)
            .Cast<Match>()
            .Select(match => $"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}")
            .ToArray();

        Console.WriteLine(string.Join(Environment.NewLine, matches));
    }
}
