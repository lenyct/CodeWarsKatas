using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KataTesting
{
    [TestFixture]
    class Tests
    {
            [Test]
            public void ExamplesTests()
            {
                Assert.AreEqual(CodeWarsKatas.Katas.Mask("4556364607935616"), "############5616");
                Assert.AreEqual(CodeWarsKatas.Katas.Mask("1"), "1");
                Assert.AreEqual(CodeWarsKatas.Katas.Mask("11111"), "#1111");
            }

            [Test]
            public void ShouldFailNegativeNumber()
            {
                Assert.Throws<ArgumentException>(delegate {CodeWarsKatas.Katas.CalculateAreaOfCircle("-123"); });
                //Assert.Throws(typeof(ArgumentException),CodeWarsKatas.Katas..CalculateAreaOfCircle("-123"));
            }

            [Test]
            public void ShouldFailAlphaNumeric()
            {
                Assert.Throws<ArgumentException>(delegate {CodeWarsKatas.Katas.CalculateAreaOfCircle("number"); });
            }

            [Test]
            public void ShouldPass1()
            {
                Assert.AreEqual(5881.25,CodeWarsKatas.Katas.CalculateAreaOfCircle("43.2673"));
            }

            [Test]
            public void GetMissingCandiesTest_5_8_6_4()
            {
                int[] input = { 5, 8, 6, 4 };
                int expected = 9;

                int actual = CodeWarsKatas.Katas.GetMissingCandies(input);

                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetMissingCandiesTest_1_2_4_6()
            {
                int[] input = { 1, 2, 4, 6 };
                int expected = 11;

                int actual = CodeWarsKatas.Katas.GetMissingCandies(input);

                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetMissingCandiesTest_1_2()
            {
                int[] input = { 1, 2 };
                int expected = 1;

                int actual = CodeWarsKatas.Katas.GetMissingCandies(input);

                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void GetMissingCandiesTest_4_2()
            {
                int[] input = { 4, 2 };
                int expected = 2;

                int actual = CodeWarsKatas.Katas.GetMissingCandies(input);

                Assert.AreEqual(expected, actual);
            }

            [Test]
            public void OrderDescending()
            {
                Assert.AreEqual(654321, CodeWarsKatas.Katas.DescendingOrder(145263));
            }  
    }
}
