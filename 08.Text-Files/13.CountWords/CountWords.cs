using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class CountWords
{
    static void Main()
    {
        try
        {
            var firstReader = new StreamReader(@"..\..\words.txt");
            var secondReader = new StreamReader(@"..\..\test.txt");
            var writer = new StreamWriter(@"..\..\result.txt");

            var dictionary = new Dictionary<string, int>();

            using (firstReader)
            {
                string line = firstReader.ReadLine();
                while (line != null)
                {
                    dictionary.Add(line, 0);
                    line = firstReader.ReadLine();
                }
            }

            using (secondReader)
            {
                string[] text = secondReader.ReadToEnd().ToLower().Split(' ', '.', ',', ':', '?', '!');
                foreach (var word in text)
                {
                    if (dictionary.ContainsKey(word))
                    {
                        dictionary[word]++;
                    }
                }
            }

            var result = dictionary.OrderByDescending(x => x.Value);

            using (writer)
            {
                foreach (var item in result)
                {
                    writer.WriteLine(item);
                }
            }
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