namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            range<double> range = new range<double>(23.5, 27.9);
            Console.WriteLine(range.IsInRange(25.7));
            Console.WriteLine(range.IsInRange(29.1));
            Console.WriteLine(range.Length());
        }
    }
}
