using _30DaysOfCoding.Days.Day0;
using NUnit.Framework;

namespace _30DaysOfCodingTest
{
    public class Tests
    {
        [Test]
        public void InputResultOK()
        {
            string message = "This is a test";

            string output = Day0.Greet(message);

            Assert.AreEqual(message, output);
        }

        [Test]
        public void ValidationForEmptyString()
        {
            string message = string.Empty;

            string expectedOutput = "Sin Input";

            string output = Day0.Greet(message);

            Assert.AreEqual(expectedOutput, output);
        }
    }
}