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

        
    }
}
