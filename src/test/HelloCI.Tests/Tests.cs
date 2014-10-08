using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCI.Tests {
    [TestFixture]
    public class Tests {
        [Test, Ignore]
        public void FailTest() {
            Assert.AreEqual(1,2);
        }

        [Test]
        public void PassTest() {
            Assert.Pass("This test always passes");
        }
    }
}
