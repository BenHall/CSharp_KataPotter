using NUnit.Framework;

namespace KataPotter.Specs
{
    [TestFixture]
    public class TestEdgeCases : Implementation
    {
        [Test]
        public void One()
        {
            Assert.AreEqual(2 * (8 * 4 * 0.8), price(new int[] { 0, 0, 1, 1, 2, 2, 3, 4 }));
        }

        [Test]
        public void Two()
        {
            Assert.AreEqual(3 * (8 * 5 * 0.75) + 2 * (8 * 4 * 0.8), price(new int[] {
                                                                                        0, 0, 0, 0, 0, 
                                                                                        1, 1, 1, 1, 1, 
                                                                                        2, 2, 2, 2, 
                                                                                        3, 3, 3, 3, 3, 
                                                                                        4, 4, 4, 4}));
        }
    }
}