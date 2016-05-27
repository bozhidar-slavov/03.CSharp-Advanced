using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        var client = new WebClient();
        try
        {
            Console.Write("Enter link to download image: ");
            string link = Console.ReadLine();
            Console.Write("Enter image name and .jpeg format: ");
            string imageName = Console.ReadLine();

            client.DownloadFile(link, imageName);
            Console.WriteLine(@"Downloaded in ""bin"" directory!");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (WebException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (NotSupportedException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}