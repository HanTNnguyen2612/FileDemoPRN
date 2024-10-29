class Program
{
    static void Main(string[] args)
    {
        string path = @"MyData.txt";
        if (!File.Exists(path))
        {
            string createText = "Hello and Welcome" + Environment.NewLine;
            File.WriteAllText(path, createText);
        }
        string appendText = "This is extra text" + Environment.NewLine;
        File.AppendAllText(path, appendText);
        string readText = File.ReadAllText(path);
        Console.WriteLine(readText);
        Console.ReadLine();
    }
}