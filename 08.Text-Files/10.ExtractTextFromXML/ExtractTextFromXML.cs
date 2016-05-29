using System;
using System.IO;
using System.Text.RegularExpressions;

class ExtractTextFromXML
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\student.xml");

        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(Regex.Replace(line, "<.*?>", string.Empty));
                line = reader.ReadLine();
            }
        }
    }
}