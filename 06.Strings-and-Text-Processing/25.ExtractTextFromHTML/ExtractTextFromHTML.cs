﻿using System;
using System.Text.RegularExpressions;

class ExtractTextFromHTML
{
    static void Main()
    {
        string html = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";

        foreach (Match item in Regex.Matches(html, "(?<=^|>)[^><]+?(?=<|$)"))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
    }
}
