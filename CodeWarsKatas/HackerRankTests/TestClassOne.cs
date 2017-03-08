using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static HackerRank.CodingInterview;

namespace HackerRankTests
{
    [TestFixture]
    public class TestClassOne
    {
        [Test]
        public void Left_Rotation_Of_Array()
        {         
            var result = RotateLeftKTimes(5, 4, new[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual("5 1 2 3 4", result);
        }

        [Test]
        public void Camel_Case_String_Counter()
        {
            var result = CamelCaseCounter("saveChangesInTheEditor");
            Assert.AreEqual(result, "5");
        }

    }
}
