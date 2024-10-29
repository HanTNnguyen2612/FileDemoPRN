namespace DemoFileClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"MyFile.txt";
            if (!File.Exists(path))
            {
                using StreamWriter sw = File.CreateText(path);
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }

            using StreamReader sr = File.OpenText(path);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}