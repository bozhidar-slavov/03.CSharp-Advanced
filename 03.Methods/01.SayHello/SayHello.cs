using System;

class SayHello
{
    static string Greeting(string name)
    {
        return string.Format("Hello, {0}!", name);
    }

    static void Main()
    {
        string name = Console.ReadLine();
        Console.WriteLine(Greeting(name));
    }
}