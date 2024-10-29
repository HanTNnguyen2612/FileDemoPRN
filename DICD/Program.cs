class Program
{
    static void Main(string[] args) {
        DirectoryInfo di = new DirectoryInfo(@"C:\Users\Admin\source\repos\Test");
        Console.WriteLine("Search pattern returns:");
        foreach (var fi in di.GetDirectories()) {
            Console.WriteLine(fi.Name);
        }
        Console.WriteLine();
        Console.WriteLine("Search pattern TopDirectoryOnly returns:");
        foreach (var fi in di.GetFiles("*.cs", SearchOption.TopDirectoryOnly)) {
            Console.WriteLine(fi.Name);
        }
        Console.ReadLine();
    }
}