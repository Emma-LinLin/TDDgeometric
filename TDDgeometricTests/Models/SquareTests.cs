using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDgeometric.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDgeometric.Models.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        [DataRow(0,0)]
        public void GetArea_Zero_ReturnZero(float inputData, float expected)
        {
            var calc = new Square(inputData);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(float.MaxValue, 0)]
        public void GetArea_MaxValue_ReturnZero(float inputData, float expected)
        {
            var calc = new Square(inputData);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow (-4, 0)]
        [DataRow(-1, 0)]
        [DataRow(-100, 0)]
        public void GetArea_NegativeNumbers_ReturnZero(float inputData, float expected)
        {
            var calc = new Square(inputData);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow (4.7f, 22.09f)]
        [DataRow(8.3f, 68.89f)]
        [DataRow(1.1f, 1.21f)]
        public void GetArea_Decimals_ReturnArea(float inputData, float expected)
        {
            var calc = new Square(inputData);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow (5, 25)]
        [DataRow(1, 1)]
        [DataRow(20, 400)]
        public void GetArea_SingleNumber_ReturnArea(float inputData, float expected)
        {
            var calc = new Square(inputData);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow (0,0)]
        public void GetPerimiter_Zero_ReturnZero(float inputData, float expected)
        {
            var calc = new Square(inputData);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(float.MaxValue, 0)]
        public void GetPerimiter_MaxValue_ReturnZero(float inputData, float expected)
        {
            var calc = new Square(inputData);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(4, 16)]
        [DataRow(5, 20)]
        [DataRow(40, 160)]
        public void GetPerimiter_SingleNumber_ReturnPerimiter(float inputData, float expected)
        {
            var calc = new Square(inputData);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(1.7f, 6.8f)]
        [DataRow(3.4f, 13.6f)]
        [DataRow(9.63f, 38.52f)]
        public void GetPerimiter_Decimals_ReturnPerimiter(float inputData, float expected)
        {
            var calc = new Square(inputData);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }
    }
}