﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CodeWarsKatas.Classes;

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

        [Test]
        public void IsItSquare()
        {
            Assert.AreEqual(false, CodeWarsKatas.Katas.IsSquare(-1), "negative numbers aren't square numbers");
            Assert.AreEqual(false, CodeWarsKatas.Katas.IsSquare(3), "3 isn't a square number");
            Assert.AreEqual(true, CodeWarsKatas.Katas.IsSquare(4), "4 is a square number");
            Assert.AreEqual(true, CodeWarsKatas.Katas.IsSquare(25), "25 is a square number");
            Assert.AreEqual(false, CodeWarsKatas.Katas.IsSquare(26), "26 isn't a square number");
        }

        [Test]
        public static void NumbersFromStringTests()
        {
            Assert.AreEqual(123, CodeWarsKatas.Katas.FilterString("123"), "Just return the numbers");
            Assert.AreEqual(123, CodeWarsKatas.Katas.FilterString("a1b2c3"), "Just return the numbers");
            Assert.AreEqual(123, CodeWarsKatas.Katas.FilterString("aa1bb2cc3dd"), "Just return the numbers");
        }

        [Test]
        public static void FixedTest()
        {
            Assert.AreEqual("test", CodeWarsKatas.Katas.FilterNumbers("test123"));
            Assert.AreEqual("abc", CodeWarsKatas.Katas.FilterNumbers("a1b2c3"));
            Assert.AreEqual("aabbccdd", CodeWarsKatas.Katas.FilterNumbers("aa1bb2cc3dd"));
        }

        [Test]
        public static void BlockTest()
        {
            Block b = new Block(new int[] { 2, 2, 2 });
            Assert.AreEqual(2, b.GetWidth());
            Assert.AreEqual(2, b.GetLength());
            Assert.AreEqual(2, b.GetHeight());
            Assert.AreEqual(8, b.GetVolume());
            Assert.AreEqual(24, b.GetSurfaceArea());
        }
    }
}
