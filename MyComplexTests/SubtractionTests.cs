using laba4_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComplexTests
{
    [TestClass]
    public class SubtractionTests
    {
        [TestMethod]
        public void SubtractSame()
        {
            MyComplex m1 = new MyComplex(3, 7);
            MyComplex m2 = new MyComplex(5, 7);
            string expected = new MyComplex(-2, 0).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractSameTwo()
        {
            MyComplex m1 = new MyComplex(24, 19);
            MyComplex m2 = new MyComplex(0, 19);
            string expected = new MyComplex(24, 0).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractSameThree()
        {
            MyComplex m1 = new MyComplex(4, 3);
            MyComplex m2 = new MyComplex(4, 3);
            string expected = new MyComplex(0, 0).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractDifferent()
        {
            MyComplex m1 = new MyComplex(3, 6);
            MyComplex m2 = new MyComplex(2, 7);
            string expected = new MyComplex(1, -1).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractDifferentTwo()
        {
            MyComplex m1 = new MyComplex(1, 25);
            MyComplex m2 = new MyComplex(2, 5);
            string expected = new MyComplex(-1, 20).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractThree()
        {
            MyComplex m1 = new MyComplex(10, 12);
            MyComplex m2 = new MyComplex(3, 7);
            string expected = new MyComplex(7, 5).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractFour()
        {
            MyComplex m1 = new MyComplex(24, 75);
            MyComplex m2 = new MyComplex(12, 30);
            string expected = new MyComplex(12, 45).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractDifferentSigns()
        {
            MyComplex m1 = new MyComplex(2, 18);
            MyComplex m2 = new MyComplex(-3, 7);
            string expected = new MyComplex(5, 11).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractDifferentSignsTwo()
        {
            MyComplex m1 = new MyComplex(-1, 75);
            MyComplex m2 = new MyComplex(2, -15);
            string expected = new MyComplex(-3, 90).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractDifferentSignsThree()
        {
            MyComplex m1 = new MyComplex(-5, -36);
            MyComplex m2 = new MyComplex(-81, -8);
            string expected = new MyComplex(76, -28).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
    }
}
