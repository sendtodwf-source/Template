using System.IO;

static void Main()
{
if (File.Exists(Path.GetFullPath("journal.txt")))
{
    Console.WriteLine("hello!");
}
    else
    {
        Console.WriteLine("bye!");
    }
}
