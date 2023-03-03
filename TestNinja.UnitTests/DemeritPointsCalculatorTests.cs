using NUnit.Framework;
using System;
using System.Runtime.Remoting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{ 
    [TestFixture]
    internal class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _calculator;
        
        [SetUp]
        public void Setup() 
        { _calculator = new DemeritPointsCalculator(); }

        [Test]
        [TestCase (-2)]
        [TestCase (301)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowsArguemetOutOfRangeException(int speed)
        {
            //var calculator = new DemeritPointsCalculator();

            Assert.That(() => _calculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase (0, 0)]
        [TestCase (50, 0)]
        [TestCase (65, 0)]
        [TestCase (66, 0)]
        [TestCase (70, 1)]
        [TestCase (75, 2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            //var calculator = new DemeritPointsCalculator();

            var result = _calculator.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expectedResult));
        }


    }
}
