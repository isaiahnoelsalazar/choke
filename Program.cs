internal class Program
{
    private static void Main(string[] args)
    {
        if (args[0] == "out")
        {
            for (long a = 1; a < args.Length; a++)
            {
                Console.Write($"{args[a]} ");
            }
        }
    }
}