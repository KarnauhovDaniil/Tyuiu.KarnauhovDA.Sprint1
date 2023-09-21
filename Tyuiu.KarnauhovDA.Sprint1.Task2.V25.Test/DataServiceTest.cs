using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KarnauhovDA.Sprint1.Task2.V25.Lib;
namespace Tyuiu.KarnauhovDA.Sprint1.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertRadsToDegrees(x);
            Assert.AreEqual(4, res);
        }
    }
}
