using System;
using System.Text;

class StringsInCSharp
{
    static void Main()
    {
        var text = new StringBuilder();
        text.AppendLine("A string is an object of type String whose value is text.");
        text.AppendLine("Internally, the text is stored as a sequential read-only collection of Char object");
        text.AppendLine("Some important methods: ");
        text.AppendLine("string.Compare()");
        text.AppendLine("string.Equals()");
        text.AppendLine("string.IndexOf()");
        text.AppendLine("string.LastIndexOf()");
        text.AppendLine("string.Substring()");
        text.AppendLine("string.Split()");
        text.AppendLine("string.ToLower()");
        text.AppendLine("string.ToUpper()");
        text.AppendLine("string.Trim()");
        text.AppendLine("string.Replace()");
        text.AppendLine("string.Remove()");

        Console.WriteLine(text.ToString());           
    }
}