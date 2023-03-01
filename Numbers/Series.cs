using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public static class Series
    {
        public static IEnumerable<int> Fibonacci(int count)
        {
            int a = 0, b = 1, c;

            for (int i = 1; i <= count; i++)
            {
                c = a + b;
                a = b;
                b = c;

                yield return c;
            }
        }

        public static IEnumerable<int> GetUniqueRandomNumbers(int count)
        {
            Random rand = new Random();

            for (int i=0; i < count; i++) 
            {
                int num = rand.Next(1, 100 + 1);
                yield return num;
            }
        }
    }
}
