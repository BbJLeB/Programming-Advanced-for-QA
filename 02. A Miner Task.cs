using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> resources = new Dictionary<string, int>();

        while (true)
        {
            string resource = Console.ReadLine();
            if (resource.ToLower() == "stop")
            {
                break;
            }

            int quantity = int.Parse(Console.ReadLine());

            if (resources.ContainsKey(resource))
            {
                resources[resource] += quantity;
            }
            else
            {
                resources[resource] = quantity;
            }
        }

        Console.WriteLine();
        foreach (var kvp in resources)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
    }
}
