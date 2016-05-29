using System.IO;

class LineNumbers
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\GoldenBallHolders.txt");
        var writer = new StreamWriter(@"..\..\WithLineNumbers.txt");

        using (reader)
        {
            string currentLine = reader.ReadLine();
            int year = 1956;
            using (writer)
            {
                while (currentLine != null)
                {
                    writer.WriteLine("{0}. {1}", year, currentLine);
                    year++;
                    currentLine = reader.ReadLine();
                }
            }
        }
    }
}