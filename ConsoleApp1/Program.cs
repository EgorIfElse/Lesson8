namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp\Lesson8.txt";
            Random r = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(r.Next(-10, 10));
                }
            }
            int k = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    if (Convert.ToInt32(sr.ReadLine()) > 0)
                    {
                        k++;
                          
                    }
                }
                Console.WriteLine(k);

            }
        }
    }
}
