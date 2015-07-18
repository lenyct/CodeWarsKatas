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
            Assert.Throws<ArgumentException>(delegate { CodeWarsKatas.Katas.CalculateAreaOfCircle("-123"); });
            //Assert.Throws(typeof(ArgumentException),CodeWarsKatas.Katas..CalculateAreaOfCircle("-123"));
        }

        [Test]
        public void ShouldFailAlphaNumeric()
        {
            Assert.Throws<ArgumentException>(delegate { CodeWarsKatas.Katas.CalculateAreaOfCircle("number"); });
        }

        [Test]
        public void ShouldPass1()
        {
            Assert.AreEqual(5881.25, CodeWarsKatas.Katas.CalculateAreaOfCircle("43.2673"));
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

        [Test]
        public void TestVowelCount()
        {
            Assert.AreEqual(10, CodeWarsKatas.Katas.GetVowelCount("abracadabraAEIOU"), "Nope!");
        }

        [Test]
        public void TestCapMe()
        {
            var result = new String[] { "Paul", "Martin", "David" };
            var test = new string[] { "PAUL", "mArTin", "david" };
            var q = CodeWarsKatas.Katas.CapMe(test);
            Assert.AreEqual(result, CodeWarsKatas.Katas.CapMe(test));
            //CapMe([new string[]{"KARLY", "DANIEL", "KELSEY"});
        }

        [Test]
        public void ReverLongerTest_1()
        {
            try
            {
                string input_a = "first";
                string input_b = "abcde";
                string expected = "abcdetsrifabcde";

                string actual = CodeWarsKatas.Katas.ShorterReverseLonger(input_a, input_b);

                Assert.AreEqual(expected, actual);
            }
            catch (System.Exception ex)
            {
                Assert.Fail("There seems to be an error in your code. The exception message reads as follow: " + ex.Message);
            }
        }

        [Test]
        public void ReverLongerTest_2()
        {
            try
            {
                string input_a = "hello";
                string input_b = "bau";
                string expected = "bauollehbau";

                string actual = CodeWarsKatas.Katas.ShorterReverseLonger(input_a, input_b);

                Assert.AreEqual(expected, actual);
            }
            catch (System.Exception ex)
            {
                Assert.Fail("There seems to be an error in your code. The exception message reads as follow: " + ex.Message);
            }
        }

        [Test]
        public void ReverLongerTest_3()
        {
            try
            {
                string input_a = "abcde";
                string input_b = "fghi";
                string expected = "fghiedcbafghi";

                string actual = CodeWarsKatas.Katas.ShorterReverseLonger(input_a, input_b);

                Assert.AreEqual(expected, actual);
            }
            catch (System.Exception ex)
            {
                Assert.Fail("There seems to be an error in your code. The exception message reads as follow: " + ex.Message);
            }
        }

        [Test]
        public void ReverLongerTest_4()
        {
            try
            {
                string input_a = "    ";
                string input_b= null;
                string expected = "";

                string actual = CodeWarsKatas.Katas.ShorterReverseLonger(input_a, input_b);

                Assert.AreEqual(expected, actual);
            }
            catch (System.Exception ex)
            {
                Assert.Fail("There seems to be an error in your code. The exception message reads as follow: " + ex.Message);
            }
        }
    }
}
