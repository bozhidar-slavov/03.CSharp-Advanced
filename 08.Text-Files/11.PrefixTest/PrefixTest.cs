using System.IO;
using System.Text.RegularExpressions;

class PrefixTest
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\text.txt");
        var writer = new StreamWriter(@"..\..\temp.txt", false);

        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    line = Regex.Replace(line, @"\b(test)\w*\b", string.Empty);
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }

        File.Delete(@"..\..\text.txt");
        File.Move(@"..\..\temp.txt", @"..\..\text.txt");
    }
}