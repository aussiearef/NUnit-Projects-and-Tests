namespace AdvancedTopicsTests
{

    [TestFixture]
    public class ParentTestClass
    {
        public ParentTestClass() { }
    }


    [TestFixture("John", "Doe")]
    [TestFixture(2025, 10, 3)]
    public class ChildTestClass : ParentTestClass
    {
        int year, month , day;
        
        string firstName, lastName;
        public ChildTestClass(int year, int month, int day) {
        
            this.year= year;
            this.month = month;
            this.day = day;
        }

        public ChildTestClass(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName= lastName;
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("{0} {1} {2}", year, month, day);
            Assert.True(true);
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine("{0} {1}", firstName, lastName);
            Assert.True(true);
        }
    }
}