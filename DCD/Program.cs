class Program
{
    static void Main(string[] args)
    {

        string sourceDirectory = Directory.GetCurrentDirectory();
        try
        {
            var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.*");
            foreach (string currentFile in txtFiles) {
                Console.WriteLine(currentFile);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.ReadLine();
    }
}