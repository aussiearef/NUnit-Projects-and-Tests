using Numbers;
using NUnit.Framework.Constraints;
using System.ComponentModel;

namespace NumbersTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(9, 3, ExpectedResult =3)]
        [TestCase(6, 2, ExpectedResult = 3, Author = "John Doe", Category = "Demo" , Description ="This is just a demo." , TestName = "Divide Numbers")]
        public int DivideNumbers(int a, int b)
        {
            return a / b;
        }

        [TestCase (Category ="Test Numbers")]
        public void GetUniqueRandomNumbers_Given_Count10_Returns_10RandomNumbers()
        {
            var numbers = Series.GetUniqueRandomNumbers(10).Distinct();

            Assert.That(numbers, Is.Unique); // NUnit 4 and above
            // NUnit.Framework.Legacy.CollectionAssert.AllItemsAreUnique(numbers); // Before NUnit 4
        }

        [TestCase(Category = "Test Numbers")]
        public void Fibonacci_Given_10_Returns10Fibonacci()
        {
            // NUnit 4 format:
            var fib = Series.Fibonacci(10);
            var subFib = Series.Fibonacci(9);

            Assert.That(fib, Is.Not.Empty);
            Assert.That(subFib, Is.Not.Empty);
            Assert.That(subFib, Is.SubsetOf(fib));
            
            /* 

            // Before NUnit 4 format:
            CollectionAssert.IsNotEmpty(fib);
            CollectionAssert.IsNotEmpty(subFib);
            CollectionAssert.IsSubsetOf(subFib, fib);

            */

            Assert.That(fib, Is.Not.Empty);
            Assert.That(subFib, Is.Not.Empty);
            Assert.That(subFib, Is.SubsetOf(fib));
        }
    }
}