using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDgeometric.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDgeometric.Models.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        [DataRow (0, 0)]
        public void GetArea_Zero_ReturnZero(float inputData, float expected)
        {
            var calc = new Circle(inputData);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(-4, 0)]
        public void GetArea_NegativeNumbers_ReturnZero(float inputData, float expected)
        {
            var calc = new Circle(inputData);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(4, 50.27f)]
        public void GetArea_SingleNumber_ReturnArea(float inputData, float expected)
        {
            var calc = new Circle(inputData);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(4.7f, 69.4f)]
        public void GetArea_Decimals_ReturnArea(float inputData, float expected)
        {
            var calc = new Circle(inputData);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(float.MaxValue, 0)]
        public void GetArea_MaxValue_ReturnZero(float inputData, float expected)
        {
            var calc = new Circle(inputData);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(0, 0)]
        public void GetPerimiter_Zero_ReturnZero(float inputData, float expected)
        {
            var calc = new Circle(inputData);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(5, 31.42f)]
        public void GetPerimiter_SingleNumber_ReturnPerimiter(float inputData, float expected)
        {
            var calc = new Circle(inputData);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(5.3f, 33.30f)]
        public void GetPerimiter_Decimals_ReturnPerimiter(float inputData, float expected)
        {
            var calc = new Circle(inputData);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(-5.3f, 0)]
        public void GetPerimiter_NegativeNumber_ReturnZero(float inputData, float expected)
        {
            var calc = new Circle(inputData);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(float.MaxValue, 0)]
        public void GetPerimiter_MaxValue_ReturnZero(float inputData, float expected)
        {
            var calc = new Circle(inputData);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }
    }
}