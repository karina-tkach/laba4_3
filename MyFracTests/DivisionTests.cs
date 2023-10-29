using laba4_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFracTests
{
    [TestClass]
    public class DivisionTests
    {
        [TestMethod]
        public void DivideSame()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(3, 7);
            string expected = new MyFrac(2, 3).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideSameTwo()
        {
            MyFrac m1 = new MyFrac(91, 801);
            MyFrac m2 = new MyFrac(2, 801);
            string expected = new MyFrac(91, 2).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideDifferent()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(5, 9);
            string expected = new MyFrac(18, 35).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideDifferentTwo()
        {
            MyFrac m1 = new MyFrac(90, 17);
            MyFrac m2 = new MyFrac(1, 11);
            string expected = new MyFrac(990, 17).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideSimplifying()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(3, 9);
            string expected = new MyFrac(6, 7).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideSimplifyingTwo()
        {
            MyFrac m1 = new MyFrac(41, 30);
            MyFrac m2 = new MyFrac(10, 5);
            string expected = new MyFrac(41, 60).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideDifferentSigns()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(-3, 7);
            string expected = new MyFrac(-2, 3).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideDifferentSignsTwo()
        {
            MyFrac m1 = new MyFrac(-13, 70);
            MyFrac m2 = new MyFrac(-2, 96);
            string expected = new MyFrac(312, 35).ToString();
            string actual = m1.Divide(m2).ToString();
            Assert.AreEqual(expected, actual, "Divide method doesn't work right");
        }
        [TestMethod]
        public void DivideByZero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => new MyFrac(6, 7).Divide(new MyFrac(0,3)));
        }
    }
}
