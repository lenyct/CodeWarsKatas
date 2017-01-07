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
            Assert.AreEqual(new Tuple<char?, int>('a', 4), Katas2.LongestRepetition("aaaabb"));
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
    }

}
