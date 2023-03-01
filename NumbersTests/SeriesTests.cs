using Numbers;
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

            CollectionAssert.AllItemsAreUnique(numbers);
        }

        [TestCase(Category = "Test Numbers")]
        public void Fibonacci_Given_10_Returns10Fibonacci()
        {
            var fib = Series.Fibonacci(10);
            var subFib = Series.Fibonacci(9);


            CollectionAssert.IsNotEmpty(fib);
            CollectionAssert.IsNotEmpty(subFib);
            CollectionAssert.IsSubsetOf(subFib, fib);

            Assert.That(fib, Is.Not.Empty);
            Assert.That(subFib, Is.Not.Empty);
            Assert.That(subFib, Is.SubsetOf(fib));
        }
    }
}