using NUnit.Framework;
using System;
using System.Threading;

namespace NUnit_Selenium
{
    [TestFixture]
    [Author("Naveen.S", "naveens@deltaww.com")]//Multiple Author details also allowed
    [Description("Nunit Attribute Snippet explaination")]
    public class Test2
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
        [Platform("Windows7")]
        public void TestCase10()
        {
            Console.WriteLine("Test Case 10");
        }

        [Test]
        [Platform(Exclude = "Win")]
        public void TestCase11()
        {
            Console.WriteLine("Test Case 11");
        }

        [Test, Timeout(20)]
        public void TestCase12()
        {
            Thread.Sleep(25);
            Console.WriteLine("Test Case 12");
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
