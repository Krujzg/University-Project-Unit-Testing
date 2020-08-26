using Assignment.Numbers;
using Assignment.Strings;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest
{
    [TestFixture]
    public class StringGeneratorTests
    {
        StringGenerator stringgenerator;
        Mock<INumberGenerator> mockedNumberGenerator;
        List<int> numbers;

        [OneTimeSetUp]
        public void Setup()
        {
            this.numbers =  new List<int>{ 1, 2, 3, 4 };

            this.mockedNumberGenerator = new Mock<INumberGenerator>();
            this.mockedNumberGenerator.Setup(x => x.GenerateEven(numbers.First())).Returns(2);
            this.mockedNumberGenerator.Setup(x => x.GenerateOdd(numbers.First())).Returns(3);

            this.stringgenerator = new StringGenerator(mockedNumberGenerator.Object);
        }

        //   /// <returns>A list of strings, containing an even and an odd positive number, separated by a comma (,). 
        //GenerateEven_Should_ThrowArgumentOutOfRangeException_When_LimitIsLowerThantZero(int input)
        [TestCase(2)]
        public void GenerateEvenOddPairs_Should_ReturnTwoAndThreeSeperatedByAComma(int paircount)
        {
            //Act
            var result = stringgenerator.GenerateEvenOddPairs(paircount, numbers.First()).First();

            //Assert
            Assert.AreEqual(result, "2,3");
            this.mockedNumberGenerator.Verify(x => x.GenerateEven(It.IsAny<int>()));
            this.mockedNumberGenerator.Verify(x => x.GenerateOdd(It.IsAny<int>()));
        }

        [TestCase(3)]
        public void GenerateEvenOddPairs_Should_ReturnAListWithTwoItemCounts(int paircount)
        {
            //Act
            var result = stringgenerator.GenerateEvenOddPairs(paircount, numbers.First());

            //Assert
            Assert.AreEqual(result.Count, 2);
            this.mockedNumberGenerator.Verify(x => x.GenerateEven(It.IsAny<int>()));
            this.mockedNumberGenerator.Verify(x => x.GenerateOdd(It.IsAny<int>()));
        }

    }
}
