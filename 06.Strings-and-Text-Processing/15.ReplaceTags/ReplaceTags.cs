using System;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        string html = Console.ReadLine();

        Console.WriteLine(Regex.Replace(html, @"<a href=""(.*?)"">(.*?)</a>", @"[$2]($1)"));
    }
}