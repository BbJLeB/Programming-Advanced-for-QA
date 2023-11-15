using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string input;

        while ((input = Console.ReadLine()) != "end")
        {
            string reversed = new string(input.Reverse().ToArray());
            Console.WriteLine($"{input} = {reversed}");
        }
    }
}
