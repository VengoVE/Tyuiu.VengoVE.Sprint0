using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VengoVE.Sprint0.Task2.V0.Lib;
namespace Tyuiu.VengoVE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = "Валентин";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Валентин", res);
        }
    }
}
