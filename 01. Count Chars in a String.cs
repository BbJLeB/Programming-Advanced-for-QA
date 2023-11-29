using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine();
        string input = Console.ReadLine();

        Dictionary<char, int> charOccurrences = CountCharacters(input);

        Console.WriteLine();
        foreach (var kvp in charOccurrences)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }

    static Dictionary<char, int> CountCharacters(string input)
    {
        Dictionary<char, int> charOccurrences = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (c != ' ')
            {
                if (charOccurrences.ContainsKey(c))
                {
                    charOccurrences[c]++;
                }
                else
                {
                    charOccurrences[c] = 1;
                }
            }
        }

        return charOccurrences;
    }
}
