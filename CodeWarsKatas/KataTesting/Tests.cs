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
    }
}
