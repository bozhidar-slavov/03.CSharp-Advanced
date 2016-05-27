using System;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        string url = Console.ReadLine();

        var collection = Regex.Match(url, "(.*)://(.*?)(/.*)").Groups;

        Console.WriteLine("[protocol] = " + collection[1]);
        Console.WriteLine("[server] = " + collection[2]);
        Console.WriteLine("[resource] = " + collection[3]);
    }
}