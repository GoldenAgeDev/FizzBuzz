using FizzBuzzConsole;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LogicTests
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        // Test num % 3 = Fizz
        public void Logic_FizzTest()
        {
            Assert.AreEqual(Logic.FizzBuzz(3), "Fizz");
        }

        [TestMethod]
        // Test num % 3 = Buzz
        public void Logic_BuzzTest()
        {
            Assert.AreEqual(Logic.FizzBuzz(5), "Buzz");
        }

        [TestMethod]
        // Test num % 3 & num % 5 = FizzBuzz
        public void Logic_FizzBuzzTest()
        {
            Assert.AreEqual(Logic.FizzBuzz(15), "FizzBuzz");
        }

        [TestMethod]
        // Random tests - change x for number of random tests
        public void Logic_RandTest()
        {
            int x = 50;
            int count = 0;

            while (count < x)
            {
                var rand = new System.Random();
                int val = rand.Next(1, 101);

                if (val % 3 == 0 && val % 5 == 0)
                {
                    Assert.AreEqual(Logic.FizzBuzz(val), "FizzBuzz");
                }

                else if (val % 3 == 0)
                {
                    Assert.AreEqual(Logic.FizzBuzz(val), "Fizz");
                }

                else if (val % 5 == 0)
                {
                    Assert.AreEqual(Logic.FizzBuzz(val), "Buzz");
                }

                else
                {
                    Assert.AreEqual(Logic.FizzBuzz(val), val.ToString());
                }

                count++;
            }
        }
    }
}
