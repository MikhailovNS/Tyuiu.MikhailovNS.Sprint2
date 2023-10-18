using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MikhailovNS.Sprint2.Task1.V3.Lib;

namespace Tyuiu.MikhailovNS.Sprint2.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Andreas()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            int a = 185;
            int b = 316;
            int c = 134;
            int d = 134;
            res = ds.GetLogicOperations(a, b, c, d);

            bool[] wait = new bool[6] { true, false, false, false, false, false };

            CollectionAssert.AreEqual(wait, res);


        }
    }
}
