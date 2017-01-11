using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CodeWarsKatas.Classes;
using CodeWarsKatas;

namespace KataTesting
{
    [TestFixture]
    public class TestsEpisode2
    {
        
        [Test]
        public void LongestAtTheBeginning()
        {
            Assert.AreEqual(new Tuple<char?, int>('a', 4), Katas2.LongestRepetitionLinq("aaaabb"));
            Assert.AreEqual(new Tuple<char?, int>('b', 5), Katas2.LongestRepetition("abbbbb"));
        }

        [Test]
        public void LongestAtTheEnd()
        {
            Assert.AreEqual(new Tuple<char?, int>('a', 4), Katas2.LongestRepetition("bbbaaabaaaa"));
        }

        [Test]
        public void LongestInTheMiddle()
        {
            Assert.AreEqual(new Tuple<char?, int>('u', 3), Katas2.LongestRepetition("cbdeuuu900"));
        }

        [Test]
        public void MultipleLongest()
        {
            Assert.AreEqual(new Tuple<char?, int>('a', 2), Katas2.LongestRepetition("aabb"));
            Assert.AreEqual(new Tuple<char?, int>('b', 1), Katas2.LongestRepetition("ba"));
        }

        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(new Tuple<char?, int>(null, 0), Katas2.LongestRepetition(""));
        }

        [Test]
        public void BasicStringReverseTests()
        {
            Assert.AreEqual(string.Empty, Katas2.Reverse(string.Empty));
            Assert.AreEqual("World  Hello", Katas2.Reverse("Hello  World"));
            Assert.AreEqual("World Hello", Katas2.Reverse("Hello World"));
            Assert.AreEqual("There. Hi", Katas2.Reverse("Hi There."));

            Assert.AreEqual("this at expert an am I", Katas2.Reverse("I am an expert at this"));
        }

        [Test]
        public static void ScrambledTest()
        {
            Assert.AreEqual(Katas2.Scramble("rkqodlw", "world"), true);
            Assert.AreEqual(Katas2.Scramble("cedewaraaossoqqyt", "codewars"), true);
            Assert.AreEqual(Katas2.Scramble("katas", "steak"), false);
            Assert.AreEqual(Katas2.Scramble("scriptjavx", "javascript"), false);
            Assert.AreEqual(Katas2.Scramble("scriptingjava", "javascript"), true);
            Assert.AreEqual(Katas2.Scramble("scriptsjava", "javascripts"), true);
            Assert.AreEqual(Katas2.Scramble("javscripts", "javascript"), false);
            Assert.AreEqual(Katas2.Scramble("aabbcamaomsccdd", "commas"), true);
            Assert.AreEqual(Katas2.Scramble("commas", "commas"), true);
            Assert.AreEqual(Katas2.Scramble("sammoc", "commas"), true);
        }

        [Test]
        public void TicTacTest()
        {
            int[,] board=  new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
            Assert.AreEqual(1, Katas2.IsSolved(board));
        }

        [Test]
        public void TicTacTest2()
        {
            int[,] board = new int[,] { 
                { 0, 1, 1 }, 
                { 2, 0, 2 }, 
                { 2, 1, 0 } };
                 Assert.AreEqual(-1, Katas2.IsSolved(board));
        }

        [Test]
        public void TicTacTest3()
        {
            int[,] board = new int[,]
            {
               {2 ,1, 2 },
               {2, 1, 1 },
               {1, 2, 1 }
            };
            Assert.AreEqual(0, Katas2.IsSolved(board));
        }
    }

}
