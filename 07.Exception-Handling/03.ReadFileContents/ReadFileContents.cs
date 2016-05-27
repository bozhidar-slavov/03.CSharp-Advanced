using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        Console.Write("Enter file name (with full path): ");
        string path = Console.ReadLine();

        try
        {
            Console.WriteLine(File.ReadAllText(path));
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (PathTooLongException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (NotSupportedException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}