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
        [DataRow(-35, -7, 0)]
        [DataRow(-2.7f, -4.5f, 0)]
        [DataRow(float.MaxValue, float.MaxValue, 0)]
        public void GetArea_Negative_ShouldReturnZero(float inputData1, float inputData2, float expected)
        {
            var calc = new Rectangle(inputData1, inputData2);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(4, 2, 8)]
        [DataRow(4, 4, 16)]
        [DataRow(50, 20, 1000)]
        [DataRow(4.4f, 2.5f, 11)]
        [DataRow(16.6f, 3.3f, 54.78f)]
        public void GetArea_Positive_ShouldReturnArea(float inputData1, float inputData2, float expected)
        {
            var calc = new Rectangle(inputData1, inputData2);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(0, 0, 0)]
        [DataRow(-1.5f, 5, 0)]
        [DataRow(7, -5.4f, 0)]
        [DataRow(float.MaxValue, float.MaxValue, 0)]
        public void GetPerimiter_Negative_ShouldReturnZero(float inputData1, float inputData2, float expected)
        {
            var calc = new Rectangle(inputData1, inputData2);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(4, 4, 16)]
        [DataRow(4.2f, 4.9f, 18.2f)]
        public void GetPerimiter_Positive_ShouldReturnPerimiter(float inputData1, float inputData2, float expected)
        {
            var calc = new Rectangle(inputData1, inputData2);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }
    }
}