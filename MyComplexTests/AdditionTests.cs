using laba4_3;

namespace MyComplexTests
{
    [TestClass]
    public class AdditionTests
    {
        [TestMethod]
        public void AddSame()
        {
            MyComplex m1 = new MyComplex(1, 3);
            MyComplex m2 = new MyComplex(1, 3);
            string expected = new MyComplex(2, 6).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
        [TestMethod]
        public void AddSameTwo()
        {
            MyComplex m1 = new MyComplex(12, 6);
            MyComplex m2 = new MyComplex(3, 6);
            string expected = new MyComplex(15, 12).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
        [TestMethod]
        public void AddDifferent()
        {
            MyComplex m1 = new MyComplex(8, 81);
            MyComplex m2 = new MyComplex(3, 11);
            string expected = new MyComplex(11, 92).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
        [TestMethod]
        public void AddDifferentTwo()
        {
            MyComplex m1 = new MyComplex(24, 75);
            MyComplex m2 = new MyComplex(13, 11);
            string expected = new MyComplex(37, 86).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
        [TestMethod]
        public void AddThree()
        {
            MyComplex m1 = new MyComplex(2, 7);
            MyComplex m2 = new MyComplex(12, 0);
            string expected = new MyComplex(14, 7).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
        [TestMethod]
        public void AddFour()
        {
            MyComplex m1 = new MyComplex(0, 15);
            MyComplex m2 = new MyComplex(12, 3);
            string expected = new MyComplex(12, 18).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
        [TestMethod]
        public void AddDifferentSigns()
        {
            MyComplex m1 = new MyComplex(3, 8);
            MyComplex m2 = new MyComplex(-3, 2);
            string expected = new MyComplex(0, 10).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
        [TestMethod]
        public void AddDifferentSignsTwo()
        {
            MyComplex m1 = new MyComplex(-10, 45);
            MyComplex m2 = new MyComplex(2, 10);
            string expected = new MyComplex(-8, 55).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
        [TestMethod]
        public void AddDifferentSignsThree()
        {
            MyComplex m1 = new MyComplex(-1, -4);
            MyComplex m2 = new MyComplex(-2, -7);
            string expected = new MyComplex(-3, -11).ToString();
            string actual = m1.Add(m2).ToString();
            Assert.AreEqual(expected, actual, "Add method doesn't work right");
        }
    }
}