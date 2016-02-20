using System;
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
        public void MaskingTest()
        {
            Assert.AreEqual(CodeWarsKatas.Katas.Mask("4556364607935616"), "############5616");
            Assert.AreEqual(CodeWarsKatas.Katas.Mask("1"), "1");
            Assert.AreEqual(CodeWarsKatas.Katas.Mask("11111"), "#1111");
        }

        [Test]
        public void ShouldFailNegativeNumberRadiusOfCirlce()
        {
            Assert.Throws<ArgumentException>(delegate { CodeWarsKatas.Katas.CalculateAreaOfCircle("-123"); });           
        }

        [Test]
        public void ShouldFailAlphaNumericRadiusOfCirlce()
        {
            Assert.Throws<ArgumentException>(delegate { CodeWarsKatas.Katas.CalculateAreaOfCircle("number"); });
        }

        [Test]
        public void ShouldPass1RadiusOfCircle()
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

        [Test]
        public void Test_54321_value()
        {
            Assert.AreEqual(1, CodeWarsKatas.Katas.FindSmallest(new int[] { 5, 4, 3, 2, 1 }, "value"));
        }

        [Test]
        public void Test_54321_index()
        {
            Assert.AreEqual(4, CodeWarsKatas.Katas.FindSmallest(new int[] { 5, 4, 3, 2, 1 }, "index"));
        }

        [Test]
        public void DeleteNth1()
        {
            var expected = new int[] { 20, 37, 21 };

            var actual = CodeWarsKatas.Katas.DeleteNth(new int[] { 20, 37, 20, 21 }, 1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void DeleteNth2()
        {
            var expected = new int[] { 1, 1, 3, 3, 7, 2, 2, 2 };

            var actual = CodeWarsKatas.Katas.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestGameStop1()
        {
            var actual=CodeWarsKatas.Katas.GameStop(24, 31);
            List<String> expected = new List<string> { "Game", "Stop", "26", "Game", "28", "29", "GameStop", "31" };
                

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestGameStop2()
        {
            var actual = CodeWarsKatas.Katas.GameStop(1, 10);
            List<String> expected = new List<string> { "1", "2", "Game", "4", "Stop", "Game", "7", "8","Game","Stop" };


            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void PersistenceTests()
        {            
            Assert.AreEqual(3, CodeWarsKatas.Katas.Persistence(39));
            Assert.AreEqual(0, CodeWarsKatas.Katas.Persistence(4));
            Assert.AreEqual(2, CodeWarsKatas.Katas.Persistence(25));
            Assert.AreEqual(4, CodeWarsKatas.Katas.Persistence(999));
        }

        [Test]
        public void StringMerge1()
        {
            Assert.IsTrue(CodeWarsKatas.Katas.isMerge("codewars", "code", "wars"), "codewars can be created from code and wars");
        }

        [Test]
        public void StringMerge2()
        {
            Assert.IsTrue(CodeWarsKatas.Katas.isMerge("codewars", "cdwr", "oeas"), "codewars can be created from cdwr and oeas");
        }

        [Test]
        public void StringMerge3()
        {
            Assert.IsFalse(CodeWarsKatas.Katas.isMerge("codewars", "cod", "wars"), "Codewars are not codwars");
        }

        [Test]
        public void CaesarCipher()
        {
            string u = "I should have known that you would have a perfect answer for me!!!";
            Assert.AreEqual(u,  CodeWarsKatas.Katas.demovingShift(CodeWarsKatas.Katas.movingShift(u, 1), 1));
        }

        [Test]
        public void CaesarCipher2()
        {
            string u = "P FEUZHQW!";
            Assert.AreEqual(u,  CodeWarsKatas.Katas.demovingShift(CodeWarsKatas.Katas.movingShift(u, 1), 1));
        }
        
        [Test]
        public void CaesarCipher3()
        {
            string u = "bdfh";
            Assert.AreEqual(u,  CodeWarsKatas.Katas.demovingShift(CodeWarsKatas.Katas.movingShift(u, 1), 1));
        }

        [Test]
        public void SimpleNumbers()
        {
            Assert.AreEqual("1", CodeWarsKatas.Katas.Pattern(1));
            Assert.AreEqual("21\n2", CodeWarsKatas.Katas.Pattern(2));
            Assert.AreEqual("54321\n5432\n543\n54\n5", CodeWarsKatas.Katas.Pattern(5));
        }

        [Test]
        public void IndexOfCaps()
        {
            Assert.AreEqual(new int[] { 0, 1, 2, 3, 4, 5 }, CodeWarsKatas.Katas.Capitals("ALLALL"));
            Assert.AreEqual(new int[] { 0 }, CodeWarsKatas.Katas.Capitals("Kata"));
        }

        [Test]
        public void EvapTests()
        {
            Assert.AreEqual(22, CodeWarsKatas.Katas.evaporator(10, 10, 10));
        }

        [Test]
        public void BasicSwapTests()
        {
            Assert.AreEqual("hELLOwORLD", CodeWarsKatas.Katas.Swap("HelloWorld"));
            Assert.AreEqual("cODEwARS", CodeWarsKatas.Katas.Swap("CodeWars"));
        }

        [Test]
        public void _0_Test_codet_With_warsedocxyz()
        {
            Hangman hangman = new Hangman("codet");

            Assert.AreEqual("_ _ _ _ _ # w", hangman.Guess('w'));
            Assert.AreEqual("_ _ _ _ _ # wa", hangman.Guess('a'));
            Assert.AreEqual("_ _ _ _ _ # war", hangman.Guess('r'));
            Assert.AreEqual("_ _ _ _ _ # war", hangman.Guess('r'));
            Assert.AreEqual("_ _ _ _ _ # wars", hangman.Guess('s'));
            Assert.AreEqual("_ _ _ e _ # wars", hangman.Guess('e'));
            Assert.AreEqual("_ _ d e _ # wars", hangman.Guess('d'));
            Assert.AreEqual("_ o d e _ # wars", hangman.Guess('o'));
            Assert.AreEqual("c o d e _ # wars", hangman.Guess('c'));
            Assert.AreEqual("c o d e _ # warsx", hangman.Guess('x'));
            Assert.AreEqual("c o d e _ # warsxy", hangman.Guess('y'));
            Assert.AreEqual("You got hung! The word was codet.", hangman.Guess('z'));
        }

        [Test]
        public void _1_Test_wars_With_wusarg()
        {            
            Hangman hangman = new Hangman("wars");

            Assert.AreEqual("w _ _ _", hangman.Guess('w'));
            Assert.AreEqual("w _ _ _ # u", hangman.Guess('u'));
            Assert.AreEqual("w _ _ s # u", hangman.Guess('s'));
            Assert.AreEqual("w a _ s # u", hangman.Guess('a'));
            Assert.AreEqual("You found the word! (wars)", hangman.Guess('r'));
            Assert.AreEqual("The game has ended.", hangman.Guess('g'));
        }

        [Test]
        public void _5_AlmostHung_owl_With_aeiubcowl()
        {
            Hangman hangman = new Hangman("owl");

            Assert.AreEqual("_ _ _ # a", hangman.Guess('a'));
            Assert.AreEqual("_ _ _ # ae", hangman.Guess('e'));
            Assert.AreEqual("_ _ _ # aei", hangman.Guess('i'));
            Assert.AreEqual("_ _ _ # aeiu", hangman.Guess('u'));
            Assert.AreEqual("_ _ _ # aeiub", hangman.Guess('b'));
            Assert.AreEqual("_ _ _ # aeiubc", hangman.Guess('c'));
            Assert.AreEqual("o _ _ # aeiubc", hangman.Guess('o'));
            Assert.AreEqual("o w _ # aeiubc", hangman.Guess('w'));
            Assert.AreEqual("You found the word! (owl)", hangman.Guess('l'));
            Assert.AreEqual("The game has ended.", hangman.Guess('g'));
            Assert.AreEqual("The game has ended.", hangman.Guess('g'));
            Assert.AreEqual("The game has ended.", hangman.Guess('g'));
            Assert.AreEqual("The game has ended.", hangman.Guess('g'));
            Assert.AreEqual("The game has ended.", hangman.Guess('g'));
            Assert.AreEqual("The game has ended.", hangman.Guess('g'));
            Assert.AreEqual("The game has ended.", hangman.Guess('g'));

        }
    }
}
