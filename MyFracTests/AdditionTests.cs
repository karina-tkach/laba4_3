using laba4_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFracTests
{
    [TestClass]
    public class AdditionTests
    {
        [TestMethod]
        public void AddSame()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(3, 7);
            string expected = new MyFrac(5, 7).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
        [TestMethod]
        public void AddSameTwo()
        {
            MyFrac m1 = new MyFrac(12, 13);
            MyFrac m2 = new MyFrac(3, 13);
            string expected = new MyFrac(15, 13).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
        [TestMethod]
        public void AddDifferent()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(3, 5);
            string expected = new MyFrac(31, 35).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
        [TestMethod]
        public void AddDifferentTwo()
        {
            MyFrac m1 = new MyFrac(24, 75);
            MyFrac m2 = new MyFrac(13, 11);
            string expected = new MyFrac(413, 275).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
        [TestMethod]
        public void AddSimplifying()
        {
            MyFrac m1 = new MyFrac(2, 7);
            MyFrac m2 = new MyFrac(12, 7);
            string expected = new MyFrac(2, 1).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
        [TestMethod]
        public void AddSimplifyingTwo()
        {
            MyFrac m1 = new MyFrac(24, 15);
            MyFrac m2 = new MyFrac(12, 30);
            string expected = new MyFrac(2, 1).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
        [TestMethod]
        public void AddDifferentSigns()
        {
            MyFrac m1 = new MyFrac(3, 8);
            MyFrac m2 = new MyFrac(-3, 16);
            string expected = new MyFrac(3, 16).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
        [TestMethod]
        public void AddDifferentSignsTwo()
        {
            MyFrac m1 = new MyFrac(-10, 45);
            MyFrac m2 = new MyFrac(2, 10);
            string expected = new MyFrac(-1, 45).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
    }
}