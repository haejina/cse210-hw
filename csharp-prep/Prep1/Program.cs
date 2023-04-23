using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string name = Console.ReadLine();
        Console.WriteLine(name);

        Console.WriteLine("What is your last name?");
        string last = Console.ReadLine();
        Console.WriteLine(last);

        Console.WriteLine($"Your name is {name}, {name} {last}.");
    }
}