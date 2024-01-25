﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VengoVE.Sprint0.Task4.V0.Lib;

namespace Tyuiu.VengoVE.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]

        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(5, DataService.Multiplication(10, 5));
        }

        [TestMethod]

        public void CheckedDivisionValid()
        {
            Assert.AreEqual(5, DataService.Division(9, 3));
        }
    }
}
