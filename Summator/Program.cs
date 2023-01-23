namespace Summator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The sum is " + Summator.Sum(new int[] {1,2,3}));
            Console.WriteLine("The average number is " + Summator.Average(new int[] {8, 10, 13}));
        }
    }
}