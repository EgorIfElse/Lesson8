namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp";
            string[] files=Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

        }
    }
}
