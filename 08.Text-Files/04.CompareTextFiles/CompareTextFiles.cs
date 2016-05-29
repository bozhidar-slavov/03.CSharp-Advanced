using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        var firstReader = new StreamReader(@"..\..\text1.txt");
        var secondReader = new StreamReader(@"..\..\text2.txt");

        int differentCount = 0;
        int sameCount = 0;
        using (firstReader)
        {
            using (secondReader)
            {
                string firstCurrentLine = firstReader.ReadLine();
                string secondCurrentLine = secondReader.ReadLine();
                while (firstCurrentLine != null && secondCurrentLine != null)
                {
                    if (firstCurrentLine == secondCurrentLine)
                    {
                        sameCount++;
                    }
                    else
                    {
                        differentCount++;
                    }

                    firstCurrentLine = firstReader.ReadLine();
                    secondCurrentLine = secondReader.ReadLine();
                }
            }
        }

        Console.WriteLine("Different lines: " + differentCount);
        Console.WriteLine("Same lines: " + sameCount);
    }
}