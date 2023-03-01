using Calculator;

namespace CalculatorTests
{
    [TestFixture]
    public class MathOperationsTests
    {
        private MathOperations operations;

        [SetUp]
        public void Setup()
        {
            operations  = new MathOperations();
        }

        [Test]
        public void Add_When_GivenTwoIntegerValues_ReturnsInteger()
        {
            var a = 1;
            var b=2;
            var c = operations.Add(a,b);

            Assert.Multiple(() => {

                Console.WriteLine("Assert.Multiple started.");

                Assert.True(c == 4);
                Assert.False(c == 4);

                Console.WriteLine("Assert.Multiple ended.");
            });

            Assert.Multiple(() => {

                Console.WriteLine("Assert.Multiple started.");

                Assert.True(c == 4);
                Assert.False(c == 4);

                Console.WriteLine("Assert.Multiple ended.");
            });


            Assert.That(c, Is.EqualTo(3), "The sum does not match.");

        }

        [Test]
        public void Add_WhenGivenTwoNonZeroValues_ReturnsNonZero()
        {
            var a = 1;
            var b = 1;
            var c = operations.Add(a,b);
            
            Assert.NotZero(c);
            Assert.That(c, Is.Not.Zero.And.LessThan(3));
        }


        [TestCase(10, 5, ExpectedResult = 5)]
        [TestCase(4, 1, ExpectedResult = 3)]
        public int Subtract_Given_TwoInts_ReturnsSubtraction(int a, int b)
        {
            var operations = new MathOperations();
            return operations.Subtract(a,b);
        }

        [TestCase(1,1, ExpectedResult = 1)]
        [TestCase(5, 5, ExpectedResult = 25)]
        public int Multiply_Given_TwoInts_ReturnsMultiply(int a, int b)
        {
            var operations = new MathOperations();
            return operations.Multiply(a, b);
        }
    }
}