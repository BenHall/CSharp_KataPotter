using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KataPotter.Specs
{
    [TestFixture]
    public class Specs
    {
        [Test]
        public void TestBasics() {
            Assert.AreEqual(0, price(new int[]{}));
            Assert.AreEqual(8, price(new int[]{0}));
            Assert.AreEqual(8, price(new int[]{1}));
            Assert.AreEqual(8, price(new int[]{2}));
            Assert.AreEqual(8, price(new int[]{3}));
            Assert.AreEqual(8, price(new int[]{4}));
            Assert.AreEqual(8 * 2, price(new int[]{0, 0}));
            Assert.AreEqual(8 * 3, price(new int[]{1,1,1}));
        }

        [Test]
        public void TestSimpleDiscounts()
        {
            Assert.AreEqual(8 * 2 * 0.95, price(new int[] { 0, 1}));
            Assert.AreEqual(8 * 3 * 0.9, price(new int[] { 0, 2, 4}));
            Assert.AreEqual(8 * 4 * 0.8, price(new int[] { 0, 1, 2, 4}));
            Assert.AreEqual(8 * 6 * 0.75, price(new int[] { 0, 1, 2, 3, 4}));
        }

        [Test]
        public void TestServeralDiscounts()
        {
            Assert.AreEqual(8 + (8 * 2 * 0.95), price(new int[] { 0, 0, 1 }));
            Assert.AreEqual(2 * (8 * 2 * 0.95), price(new int[] { 0, 0, 1, 1 }));
            Assert.AreEqual((8 * 4 * 0.8) + (8 * 2 * 0.95), price(new int[] { 0, 0, 1, 2, 2, 3 }));
            Assert.AreEqual(8 + (8 * 5 * 0.75), price(new int[] { 0, 1, 1, 2, 3, 4 }));
        }

        [Test]
        public void TestEdgeCases()
        {
            Assert.AreEqual(2 * (8 * 4 * 0.8), price(new int[] { 0, 0, 1, 1, 2, 2, 3, 4 }));
            Assert.AreEqual(3 * (8 * 5 * 0.75) + 2 * (8 * 4 * 0.8), price(new int[] {
                                                                            0, 0, 0, 0, 0, 
                                                                            1, 1, 1, 1, 1, 
                                                                            2, 2, 2, 2, 
                                                                            3, 3, 3, 3, 3, 
                                                                            4, 4, 4, 4}));
        }


        private int price(int[] array) {
            throw new NotImplementedException();
        }
    }
}
