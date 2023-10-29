using laba4_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComplexTests
{
    [TestClass]
    public class MultiplicationTests
    {
        [TestMethod]
        public void MultiplySame()
        {
            MyComplex m1 = new MyComplex(2, 7);
            MyComplex m2 = new MyComplex(3, 7);
            string expected = new MyComplex(-43, 35).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplySameTwo()
        {
            MyComplex m1 = new MyComplex(12, 11);
            MyComplex m2 = new MyComplex(25, 11);
            string expected = new MyComplex(179, 407).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplyDifferent()
        {
            MyComplex m1 = new MyComplex(2, 7);
            MyComplex m2 = new MyComplex(3, 8);
            string expected = new MyComplex(-50, 37).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplyDifferentTwo()
        {
            MyComplex m1 = new MyComplex(9, 8);
            MyComplex m2 = new MyComplex(3, 5);
            string expected = new MyComplex(-13, 69).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplyTwo()
        {
            MyComplex m1 = new MyComplex(2, 7);
            MyComplex m2 = new MyComplex(3, 0);
            string expected = new MyComplex(6, 21).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplyThree()
        {
            MyComplex m1 = new MyComplex(17, 0);
            MyComplex m2 = new MyComplex(6, 15);
            string expected = new MyComplex(102, 255).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplyFour()
        {
            MyComplex m1 = new MyComplex(0, 0);
            MyComplex m2 = new MyComplex(8, 151);
            string expected = new MyComplex(0, 0).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplyDifferentSigns()
        {
            MyComplex m1 = new MyComplex(-2, 7);
            MyComplex m2 = new MyComplex(1, 4);
            string expected = new MyComplex(-30, -1).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
        [TestMethod]
        public void MultiplyDifferentSignsTwo()
        {
            MyComplex m1 = new MyComplex(-91, 101);
            MyComplex m2 = new MyComplex(-2, 7);
            string expected = new MyComplex(-525, -839).ToString();
            string actual = m1.Multiply(m2).ToString();
            Assert.AreEqual(expected, actual, "Multiply method doesn't work right");
        }
    }
}
