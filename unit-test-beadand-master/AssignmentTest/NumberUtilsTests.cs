using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Numbers;
using NUnit.Framework;

namespace AssignmentTest
{
    [TestFixture]
    public class NumberUtilsTests
    {
        NumberUtils numberutils;

        [OneTimeSetUp]
        public void Setup()
        {
            numberutils = new NumberUtils();
        }

        [TestCase(-1)]
        [TestCase(-1203)]
        [TestCase(-122)]
        [TestCase(-431)]
        public void IsPrime_Should_ReturnFalseValue_When_InputIsLowerThanZero(int input)
        {
            //Act
            var result = numberutils.IsPrime(input);

            //Assert
            Assert.IsFalse(result);
        }

        [TestCase(9)]
        [TestCase(25)]
        [TestCase(49)]
        public void IsPrime_Should_ReturTrueValue_When_InputDivisorCountEqualsTwo(int input)
        {
            //Act
            var result = numberutils.IsPrime(input);

            //Assert
            Assert.IsTrue(result);
        }

        [TestCase(2)]
        [TestCase(10)]
        [TestCase(1000)]
        public void EvenOrOdd_Should_ReturnEvenString_When_TheInputIsAnEvenNumber(int input)
        {
            //Act
            var result = numberutils.EvenOrOdd(input);

            //Assert
            Assert.AreEqual(result, "even");
        }

        [TestCase(3)]
        [TestCase(9)]
        [TestCase(1123)]
        public void EvenOrOdd_Should_ReturnOddString_When_TheInputIsAnOddNumber(int input)
        {
            //Act
            var result = numberutils.EvenOrOdd(input);

            //Assert
            Assert.AreEqual(result, "odd");
        }

        [TestCase(3)]
        [TestCase(9)]
        [TestCase(1123)]
        public void GetDivisors_Should_ReturnTheInputNumberDivisors_When_TheInputIsInteger(int input)
        {
            //Act
            var result = numberutils.GetDivisors(input);

            //Assert
            foreach (var item in result)
            {
                Assert.That(input % item == 0);
            }
        }
    }
}
