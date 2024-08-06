using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");

        string yourName = Console.ReadLine();

        Console.WriteLine("Hello: " + yourName);
    }
}