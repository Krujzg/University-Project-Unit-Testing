using Assignment.Strings;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest
{
    [TestFixture]
    public class StringUtilTests
    {
        StringUtil stringutil;

        [OneTimeSetUp]
        public void Setup()
        {
            stringutil = new StringUtil();
        }

        [TestCase("asdsa")]
        [TestCase("évákeledelekávé")]
        public void IsPalindrom_Should_ReturnTrue_WhenStringIsPalindrom(string input)
        {
            //Act
            var result = stringutil.IsPalindrom(input);

            //Assert
            Assert.IsTrue(result);
        }

        [TestCase("fqfqegqe")]
        [TestCase("ezastringnempalindrom")]
        public void IsPalindrom_Should_ReturnFalse_WhenStringIsNotPalindrom(string input)
        {
            //Act
            var result = stringutil.IsPalindrom(input);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
