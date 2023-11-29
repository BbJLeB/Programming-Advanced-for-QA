using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, string> parkingDatabase = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split();

            if (command[0] == "register")
            {
                string username = command[1];
                string licensePlate = command[2];

                if (parkingDatabase.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {parkingDatabase[username]}");
                }
                else
                {
                    parkingDatabase[username] = licensePlate;
                    Console.WriteLine($"{username} registered {licensePlate} successfully");
                }
            }
            else if (command[0] == "unregister")
            {
                string username = command[1];

                if (parkingDatabase.ContainsKey(username))
                {
                    Console.WriteLine($"{username} unregistered successfully");
                    parkingDatabase.Remove(username);
                }
                else
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                }
            }
        }

        foreach (var kvp in parkingDatabase)
        {
            Console.WriteLine($"{kvp.Key} => {kvp.Value}");
        }
    }
}
