using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void CompareTest1()
        {
            var circleRadius = 2;
            var sideOfaSquare = 3;
            var message = Logic.Compare(circleRadius, sideOfaSquare);
            Assert.AreEqual("Площадь Круга больше площади квадрата", message);


        }
        [TestMethod()]
        public void CompareTest2()
        {
            var circleRadius = 1;
            var sideOfaSquare = 7;
            var message = Logic.Compare(circleRadius, sideOfaSquare);
            Assert.AreEqual("Площадь Круга меньше площади квадрата", message);
        }
        [TestMethod()]
        public void CompareTest3()
        {
            var circleRadius = Math.Sqrt(Math.PI);
            var sideOfaSquare = Math.PI;
            var message = Logic.Compare(circleRadius, sideOfaSquare);
            Assert.AreEqual("Площадь Круга и площадь квадрата равны", message);


        }
    }
}