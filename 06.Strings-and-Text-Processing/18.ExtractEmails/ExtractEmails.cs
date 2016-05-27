using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static string[] ExtractMails(string text)
    {
        string regexPattern = @"\b[A-Z0-9._-]+@[A-Z0-9][A-Z0-9.-]{0,61}[A-Z0-9]\.[A-Z.]{2,6}\b";

        MatchCollection matches = Regex.Matches(text, regexPattern, RegexOptions.IgnoreCase);

        string[] matchList = new string[matches.Count];
        
        int counter = 0;
        foreach (Match match in matches)
        {
            matchList[counter] = match.ToString();
            counter++;
        }

        return matchList;
    }

    static void Main()
    {
        Console.Write("Enter text: ");
        string[] emails = ExtractMails(Console.ReadLine());

        foreach (var mail in emails)
        {
            Console.WriteLine(mail);
        }
    }
}