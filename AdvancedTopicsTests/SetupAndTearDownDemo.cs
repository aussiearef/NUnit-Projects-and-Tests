using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopicsTests
{
    public class SetupAndTearDownDemo
    {

        [SetUp] public void Setup()
        {
            Console.WriteLine("Setup was executed.");
        }
        [TearDown] public void TearDown()
        {
            Console.WriteLine("TearDown was executed.");
        }

        [OneTimeSetUp] 
        public void OneTimeSetUp() 
        {
            Console.WriteLine("OneTimeSetup was executed.");
        }

        [OneTimeTearDown] 
        public void OneTimeTearDown()
        {
            Console.WriteLine("OneTimeTearDown was executed");
        }

        [Test]
        public void Test1() {
            Assert.Pass();
        }

        [Test] 
        public void Test2() {
            Assert.Pass();
        }
    }
}
