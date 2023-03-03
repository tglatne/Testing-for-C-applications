using NUnit.Framework;
using System.Runtime.Remoting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {

        private Math _math;

        [SetUp]
        public void Setup()
        { _math = new Math(); }
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguements()
        { 

            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArguement(int a, int b, int expectedResult)
        {

            var result  = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));

        }

        [Test]
        public void GetOddNumbers_LimitGreaterThanZero_ReturnOddNumbersUptoLimit()
        {
            var result = _math.GetOddNumbers(7);

            Assert.That(result, Is.Not.Empty);

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5, 7 }));
        }

        [Test]
        public void GetOddNumbers_LimitIsEqualnZero_ReturnEmptyArray()
        {
            var result = _math.GetOddNumbers(0);

            Assert.That(result, Is.Empty);
        }


    }
}
