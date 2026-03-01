internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            foreach (var arg in args)
            {
                Console.Write($"{arg} ");
            }
        }
        catch { }
    }
}