using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDgeometric.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDgeometric.Models.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        [DataRow(0,0,0)]
        public void GetArea_Zero_ReturnZero(float inputData1, float inputData2, float expected)
        {
            var calc = new Rectangle(inputData1, inputData2);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(float.MaxValue, float.MaxValue, 0)]
        public void GetArea_MaxValue_ReturnZero(float inputData1, float inputData2, float expected)
        {
            var calc = new Rectangle(inputData1, inputData2);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(4, 2, 8)]
        [DataRow(4, 4, 16)]
        [DataRow(50, 20, 1000)]
        public void GetArea_SingleNumber_Area(float inputData1, float inputData2, float expected)
        {
            var calc = new Rectangle(inputData1, inputData2);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(-4, -2, 0)]
        [DataRow(-35, -7, 0)]
        [DataRow(-2.7f, -4.5f, 0)]
        public void GetArea_NegativeNumbers_Area(float inputData1, float inputData2, float expected)
        {
            var calc = new Rectangle(inputData1, inputData2);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(4.4f, 2.5f, 11)]
        [DataRow(16.6f, 3.3f, 54.78f)]
        [DataRow(100.01f, 20.3f, 2030.203f)]
        public void GetArea_Decimals_Area(float inputData1, float inputData2, float expected)
        {
            var calc = new Rectangle(inputData1, inputData2);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(0, 0, 0)]
        public void GetPerimiter_Zero_ReturnZero(float inputData1, float inputData2, float expected)
        {
            var calc = new Rectangle(inputData1, inputData2);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(float.MaxValue, float.MaxValue, 0)]
        public void GetPerimiter_MaxValue_ReturnZero(float inputData1, float inputData2, float expected)
        {
            var calc = new Rectangle(inputData1, inputData2);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(4, 4, 16)]
        public void GetPerimiter_SingleNumbers_ReturnPerimiter(float inputData1, float inputData2, float expected)
        {
            var calc = new Rectangle(inputData1, inputData2);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(4.2f, 4.9f, 18.2f)]
        public void GetPerimiter_Decimals_ReturnPerimiter(float inputData1, float inputData2, float expected)
        {
            var calc = new Rectangle(inputData1, inputData2);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }
    }
}