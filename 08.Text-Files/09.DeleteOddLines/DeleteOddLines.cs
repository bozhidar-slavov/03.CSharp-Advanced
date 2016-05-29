using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\text.txt");
        var writer = new StreamWriter(@"..\..\temp.txt");

        using (reader)
        {
            using (writer)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        writer.WriteLine(line);
                    }

                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }

        File.Copy(@"..\..\temp.txt", @"..\..\text.txt", true);
        File.Delete(@"..\..\temp.txt");
    }
}