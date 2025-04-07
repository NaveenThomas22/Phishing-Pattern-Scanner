using System;

class Program()
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the url :");
        string url = Console.ReadLine();
        bool isSuspicouis = CheckForPhishing(url);
        if (isSuspicouis)
        {
            Console.WriteLine("Warning: This URL looks suspicious!");
        }
        else
        {
            Console.WriteLine("This URL seems okay based on basic checks.");
        }

    }

    public static bool CheckForPhishing(string url)
    {
        if (url.Length > 75)
        {
            return true;

        }

        if (url.Contains("a") || url.Contains("//") || url.Contains("http://http"))
        {
            return true;
        }
        if (!url.Contains(".") || url.EndsWith(".exe"))
        {
            return true;
        }
        return false;
    }
}