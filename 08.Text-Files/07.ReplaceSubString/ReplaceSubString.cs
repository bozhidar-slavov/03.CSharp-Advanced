using System.IO;

class ReplaceSubString
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
                    string replace = line.Replace("start", "finish");
                    writer.WriteLine(replace);
                    line = reader.ReadLine();
                }
            }
        }
    }
}