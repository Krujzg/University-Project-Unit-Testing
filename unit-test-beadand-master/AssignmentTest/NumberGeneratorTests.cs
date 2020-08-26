using Assignment.Numbers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest
{
    [TestFixture]
    public class NumberGeneratorTests
    {
        NumberGenerator numbergenerator;
        [OneTimeSetUp]
        public void Setup()
        {
            numbergenerator = new NumberGenerator();
        }

        [TestCase(-1)]
        [TestCase(-10)]
        public void GenerateEven_Should_ThrowArgumentOutOfRangeException_When_LimitIsLowerThantZero(int input)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => numbergenerator.GenerateEven(input));
        }

        [TestCase(1)]
        [TestCase(10)]
        [TestCase(110213)]
        public void GenerateEven_Should_ReturnRandomEvenNumber_When_LimitIsGreaterThantZero(int input)
        {
            //Act
            var result = numbergenerator.GenerateEven(input);

            //Assert
            Assert.That(result % 2 == 0);
        }

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(100)]
        [TestCase(1001)]
        public void GenerateOdd_Should_ReturnRandomPositiveOddNumber_When_LimitIsGreaterThanOne(int input)
        {
            //Act
            var result = numbergenerator.GenerateOdd(input);

            //Assert
            Assert.That(result % 2 == 1);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-33)]
        [TestCase(-12013)]
        public void GenerateOdd_Should_ThrowArgumentOutOfRangeException_When_LimitIsLowerThanOne(int input)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => numbergenerator.GenerateOdd(input));
        }
    }
}
