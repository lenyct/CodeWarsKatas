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
        public void FactorialTests()
        {
            Assert.AreEqual("1", Katas2.Factorial(1));
            Assert.AreEqual("120", Katas2.Factorial(5));
            Assert.AreEqual("362880", Katas2.Factorial(9));
            Assert.AreEqual("1307674368000", Katas2.Factorial(15));
            Assert.AreEqual("13462012475717524605876073858941615558355851148193967190051391468057460367090535696797920946629681836680869097041958983702264048370902871114013579941370766400374327741701139895604871545254810788060989321379840000000000000000000000000000000000", Katas2.Factorial(140));
        }


        [Test]
        public void TestBraces1()
        {
            Assert.AreEqual(true, Katas2.ValidBraces("()"));
            Assert.AreEqual(true, Katas2.ValidBraces("(){}[]"));
            Assert.AreEqual(false, Katas2.ValidBraces("(}"));
            Assert.AreEqual(false, Katas2.ValidBraces("[(])"));
            Assert.AreEqual(true, Katas2.ValidBraces("([{}])"));
        }

        [Test]
        public void TestBraces2()
        {

            Assert.AreEqual(false, Katas2.ValidBraces("[(])"));
        }
    }

}
