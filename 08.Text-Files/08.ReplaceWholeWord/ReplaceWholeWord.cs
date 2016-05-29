using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWord
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\input.txt");
        var writer = new StreamWriter(@"..\..\output.txt");

        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    string replace = Regex.Replace(line, @"\bstart\b", "finish");
                    writer.WriteLine(replace);
                    line = reader.ReadLine();
                }
            }
        }
    }
}