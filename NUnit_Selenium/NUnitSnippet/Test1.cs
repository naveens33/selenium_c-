using NUnit.Framework;
using System;
using System.Threading;

namespace NUnit_Selenium
{
    [TestFixture]
    [Author("Naveen.S", "naveens@deltaww.com")]//Multiple Author details also allowed
    [Description("Nunit Attribute Snippet explaination")]
    public class Test1
    {
        [OneTimeSetUp]
        public void onetimesetup()
        {
            Console.WriteLine("OneTimeSetUp");
        }
 
        [SetUp]
        public void setup()
        {
            Console.WriteLine("Setup");
        }

        [Test]
        public void TestCase1()
        {
            Console.WriteLine("Test Case 1");
        }

        [Test, Explicit]
        public void TestCase2()
        {
            Console.WriteLine("Test Case 2");
        }

        [Test, Combinatorial]
        public void TestCase3([Values("Australia", "Canada", "Denmark")] string country, [Values("56", "89")] string amount)
        {
            Console.WriteLine("Test Case 3 -- Value: " + country + " " + amount);
        }


        [Test]
        [Ignore("This testcase is Ignored")]
        public void TestCase4()
        {
            Console.WriteLine("Test Case 4");
        }

        [Test]
        [Ignore("Waiting for Developer to fix the bugs", Until = "2018-11-21 01:22:00Z")]
        public void TestCase5()
        {
            Console.WriteLine("Test Case 5");
        }

        [Test, MaxTime(20)] //milliseconds 
        public void TestCase6()
        {
            Thread.Sleep(25);
            Console.WriteLine("Test Case 6");
        }

        [Test, Order(3)]
        public void TestCase7()
        {
            Console.WriteLine("Test Case 7");
        }

        [Test, Order(1)]
        public void TestCase8()
        {
            Console.WriteLine("Test Case 8");
        }

        [Test, Order(2)]
        public void TestCase9()
        {
            Console.WriteLine("Test Case 9");
        }

        [TearDown]
        public void teardown()
        {
            Console.WriteLine("TearDown");
        }

        [OneTimeTearDown]
        public void onetimeteardown()
        {
            Console.WriteLine("OneTimeTearDown");
        }
    }
}
