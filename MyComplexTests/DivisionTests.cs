using laba4_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyComplexTests
{
    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        public void DivideSame()
        {
            MyComplex m1 = new MyComplex(2, 5);
            MyComplex m2 = new MyComplex(10, 5);
            string expected = new MyComplex(0.36, 0.32).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideSameTwo()
        {
            MyComplex m1 = new MyComplex(1, 6);
            MyComplex m2 = new MyComplex(2, 6);
            string expected = new MyComplex(0.95, 0.15).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideDifferent()
        {
            MyComplex m1 = new MyComplex(1, 6);
            MyComplex m2 = new MyComplex(4, 8);
            string expected = new MyComplex(0.65, 0.2).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideDifferentTwo()
        {
            MyComplex m1 = new MyComplex(5, 12);
            MyComplex m2 = new MyComplex(2, 10);
            string expected = new MyComplex(1.25, -0.25).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideTwo()
        {
            MyComplex m1 = new MyComplex(2, 6);
            MyComplex m2 = new MyComplex(-3, 9);
            string expected = new MyComplex(0.5333333333333333, -0.4).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideThree()
        {
            MyComplex m1 = new MyComplex(41, 30);
            MyComplex m2 = new MyComplex(10, 5);
            string expected = new MyComplex(4.48, 0.76).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideDifferentSigns()
        {
            MyComplex m1 = new MyComplex(2, 7);
            MyComplex m2 = new MyComplex(-3, -6);
            string expected = new MyComplex(-1.0666666666666667, -0.2).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideDifferentSignsTwo()
        {
            MyComplex m1 = new MyComplex(-12, 6);
            MyComplex m2 = new MyComplex(-2, 16);
            string expected = new MyComplex(0.46153846153846156, 0.6923076923076923).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideByZero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => new MyComplex(6, 7).Divide(new MyComplex(0, 0)));
        }
    }
}
