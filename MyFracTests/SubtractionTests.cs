using laba4_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFracTests
{
    [TestClass]
    public class SubtractionTests
    {
        [TestMethod]
        public void SubtractSame()
        {
            MyFrac m1 = new MyFrac(3, 7);
            MyFrac m2 = new MyFrac(5, 7);
            string expected = new MyFrac(-2, 7).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractSameTwo()
        {
            MyFrac m1 = new MyFrac(24, 19);
            MyFrac m2 = new MyFrac(0, 19);
            string expected = new MyFrac(24, 19).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractDifferent()
        {
            MyFrac m1 = new MyFrac(3, 6);
            MyFrac m2 = new MyFrac(2, 7);
            string expected = new MyFrac(3, 14).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractDifferentTwo()
        {
            MyFrac m1 = new MyFrac(1, 25);
            MyFrac m2 = new MyFrac(2, 5);
            string expected = new MyFrac(-9, 25).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractSimplifying()
        {
            MyFrac m1 = new MyFrac(10, 7);
            MyFrac m2 = new MyFrac(3, 7);
            string expected = new MyFrac(1, 1).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractSimplifyingTwo()
        {
            MyFrac m1 = new MyFrac(24, 75);
            MyFrac m2 = new MyFrac(12, 30);
            string expected = new MyFrac(-2, 25).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractDifferentSigns()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(-3, 7);
            string expected = new MyFrac(5, 7).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
        [TestMethod]
        public void SubtractDifferentSignsTwo()
        {
            MyFrac m1 = new MyFrac(-1, 75);
            MyFrac m2 = new MyFrac(2, 17);
            string expected = new MyFrac(-167, 1275).ToString();
            string actual = m1.Subtract(m2).ToString();
            Assert.AreEqual(expected, actual, "Subtract method doesn't work right");
        }
    }
}
