using NUnit.Framework;

namespace KataPotter.Specs
{
    [TestFixture]
    public class TestSimpleDiscounts : Implementation
    {
        [Test]
        public void One()
        {
            Assert.AreEqual(8 * 2 * 0.95, price(new int[] { 0, 1 }));
        }

        [Test]
        public void Two()
        {
            Assert.AreEqual(8 * 3 * 0.9, price(new int[] { 0, 2, 4 }));
        }

        [Test]
        public void Three()
        {
            Assert.AreEqual(8 * 4 * 0.8, price(new int[] { 0, 1, 2, 4 }));
        }

        [Test]
        public void Four()
        {
            Assert.AreEqual(8 * 5 * 0.75, price(new int[] { 0, 1, 2, 3, 4 }));
        }
    }
}
