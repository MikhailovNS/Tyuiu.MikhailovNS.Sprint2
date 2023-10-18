using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint2.Task6.V13.Lib;

namespace Tyuiu.MikhailovNS.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Baddie()
        {
            DataService ds = new DataService();
            int n = 31;
            int m = 12;
            int g = 2002;
            var res = ds.FindDateOfNextDay(g, m, n);
            var wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
