using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint2.Task4.V2.Lib;

namespace Tyuiu.MikhailovNS.Sprint2.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void RayanKuzming()
        {
            DataService ds = new DataService();
            double x = 8;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 11;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void DanilKyzling()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 1.25;
            Assert.AreEqual(wait, res);
        }
    }
}
