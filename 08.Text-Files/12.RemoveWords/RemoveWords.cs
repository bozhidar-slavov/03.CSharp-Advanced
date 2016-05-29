using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class RemoveWords
{
    static void Main()
    {
        List<string> words = new List<string>();

        try
        {
            var firstReader = new StreamReader("../../text.txt");
            var secondReader = new StreamReader("../../words.txt");
            var writer = new StreamWriter("../../temp.txt", false);

            using (secondReader)
            {
                string line = secondReader.ReadLine();
                while (line != null)
                {
                    words.Add(line);
                    line = secondReader.ReadLine();
                }
            }

            using (firstReader)
            {
                using (writer)
                {
                    string line = firstReader.ReadLine();
                    while (line != null)
                    {
                        foreach (string word in words)
                        {
                            line = Regex.Replace(line, word, string.Empty);
                        }

                        writer.WriteLine(line);
                        line = firstReader.ReadLine();
                    }
                }
            }

            File.Delete("../../text.txt");
            File.Move("../../temp.txt", "../../text.txt");
            
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}