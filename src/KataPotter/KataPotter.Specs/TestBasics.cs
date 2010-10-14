using NUnit.Framework;

namespace KataPotter.Specs
{
    [TestFixture]
    public class TestBasics : Implementation
    {
        [Test]
        public void One() {
            Assert.AreEqual(0, price(new int[] { })); 
        }

        [Test]
        public void Two()
        {
            Assert.AreEqual(8, price(new int[] { 0 }));
        }
        [Test]
        public void Three()
        {
            Assert.AreEqual(8, price(new int[] { 1 }));
        }
        [Test]
        public void Four()
        {
            Assert.AreEqual(8, price(new int[] { 2 }));
        }
        [Test]
        public void Five()
        {
            Assert.AreEqual(8, price(new int[] { 3 }));
        }
        [Test]
        public void Six()
        {
            Assert.AreEqual(8, price(new int[] { 4 }));
        }
        [Test]
        public void Seven()
        {
            Assert.AreEqual(8 * 2, price(new int[] { 0, 0 }));
        }

        [Test]
        public void Eight()
        {
            Assert.AreEqual(8 * 3, price(new int[] { 1, 1, 1 }));
        }
    }
}