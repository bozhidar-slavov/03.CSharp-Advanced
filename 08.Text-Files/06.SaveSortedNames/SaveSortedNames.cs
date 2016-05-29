using System.Collections.Generic;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\input.txt");
        var writer = new StreamWriter(@"..\..\output.txt");

        var list = new List<string>();
        using (reader)
        {
            string currentLine = reader.ReadLine();
            while (currentLine != null)
            {
                list.Add(currentLine);
                currentLine = reader.ReadLine();
            }

            list.Sort();
        }

        using (writer)
        {
            foreach (var name in list)
            {
                writer.WriteLine(name);
            }
        }
    }
}