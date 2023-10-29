using laba4_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFracTests
{
    [TestClass]
    public class MultiplicationTests
    {
        [TestMethod]
        public void MultiplySame()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(3, 7);
            string expected = new MyFrac(6, 49).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplySameTwo()
        {
            MyFrac m1 = new MyFrac(-12, 11);
            MyFrac m2 = new MyFrac(25, 11);
            string expected = new MyFrac(-300, 121).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplyDifferent()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(3, 8);
            string expected = new MyFrac(6, 56).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplyDifferentTwo()
        {
            MyFrac m1 = new MyFrac(-9, 8);
            MyFrac m2 = new MyFrac(3, 5);
            string expected = new MyFrac(-27, 40).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplySimplifying()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(3, 9);
            string expected = new MyFrac(2, 21).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplySimplifyingTwo()
        {
            MyFrac m1 = new MyFrac(-17, 8);
            MyFrac m2 = new MyFrac(6, 15);
            string expected = new MyFrac(-17, 20).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplyDifferentSigns()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(-3, 7);
            string expected = new MyFrac(-6, 49).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplyDifferentSignsTwo()
        {
            MyFrac m1 = new MyFrac(-91, 801);
            MyFrac m2 = new MyFrac(-2, 7);
            string expected = new MyFrac(26, 801).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
    }
}
