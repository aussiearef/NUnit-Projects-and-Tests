namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            foreach(int item in Series.Fibonacci(10))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}