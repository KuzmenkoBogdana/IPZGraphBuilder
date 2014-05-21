using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice;
using System.Windows.Forms;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Form1 p=new Form1();
        [TestMethod]
        public void TestSin()
        {
            double A = 1;
            double B = 1;
            double x = 90;
            double y = A * Math.Sin(B * x);
            double expected = y;
            double actual = p.sin(x);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void TestCos()
        {
            double A = 1;
            double B = 1;
            double x = 90;
            double y = A * Math.Cos(B * x);
            double expected = y;
            double actual = p.cos(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestLine()
        {
            double k = 1;
            double b = 1;
            double x = 0;
            double y = k * x + b;
            double expected = y;
            double actual = p.line(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestParabola()
        {
            double A = 0;
            double B = 0;
            double C = 1;
            double x = 1;
            double y = A * Math.Pow(x, 2) + B * x + C;
            double expected = y;
            double actual = p.parabola(x);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestTg()
        {
            double x = 30;
            double A = 1;
            double B = 1;
            double y = A * Math.Tan(B * x);
            double expected = y;
            double actual = p.tg(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod, Timeout(200)]
        public void TimedTest()
        {
            double k = 1;
            double x = 1;
            double d = 1;
            double b = 0;
            double y = d * Math.Sqrt(k * x + b);
            double expected = y;

        }
        
    }
}
