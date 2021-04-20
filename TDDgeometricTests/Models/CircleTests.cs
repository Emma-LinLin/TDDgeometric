﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        [DataRow(-4, 0)]
        [DataRow(float.MaxValue, 0)]
        public void GetArea_Negative_ShouldReturnZero(float inputData, float expected)
        {
            var calc = new Circle(inputData);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(4, 50.27f)]
        [DataRow(4.7f, 69.4f)]
        public void GetArea_Positive_ShouldReturnArea(float inputData, float expected)
        {
            var calc = new Circle(inputData);
            var actual = calc.GetArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(0, 0)]
        [DataRow(-5.3f, 0)]
        [DataRow(float.MaxValue, 0)]
        public void GetPerimiter_Negative_ShouldReturnZero(float inputData, float expected)
        {
            var calc = new Circle(inputData);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(5, 31.42f)]
        [DataRow(5.3f, 33.30f)]
        public void GetPerimiter_Positive_ShouldReturnPerimiter(float inputData, float expected)
        {
            var calc = new Circle(inputData);
            var actual = calc.GetPerimiter();
            Assert.AreEqual(expected, actual);
        }
    }
}