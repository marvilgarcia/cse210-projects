using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        String name = Console.ReadLine();
        Console.Write("What is your last name? ");
        String lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {name} {lastName}.");


    }
}