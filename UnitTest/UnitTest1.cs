using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EParser;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ExpressionParser p = new ExpressionParser();
            Func f = p.GetFunction("-10^(-3)");
        }
    }
}
