using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        var firstReader = new StreamReader(@"..\..\CSharp.txt");
        var secondReader = new StreamReader(@"..\..\JavaScript.txt");
        var writer = new StreamWriter(@"..\..\ProgrammingLanguages.txt");

        using (writer)
        {
            using (firstReader)
            {
                writer.WriteLine("First text");
                writer.WriteLine(firstReader.ReadToEnd());
                writer.WriteLine();
            }
            using (secondReader)
            {
                writer.WriteLine("Second text");
                writer.WriteLine(secondReader.ReadToEnd());
            }
        }
    }
}