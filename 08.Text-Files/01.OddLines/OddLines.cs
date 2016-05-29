using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\text.txt");

        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                }

                line = reader.ReadLine();
                lineNumber++;
            }
        }
    }
}