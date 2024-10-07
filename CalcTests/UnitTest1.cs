using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalaizerClassLibrary;
using CalcClassBr;
using System;
namespace CalcTests.Tests
{
    [TestClass]
    public class CalcTests
    {
        public TestContext TestContext { get; set; }
        [DataSource("System.Data.SqlClient", @"Data Source=DESKTOP-AOVML30\SQLEXPRESS;Initial Catalog=CalcTestsBD;Integrated Security=True;", "TestCases", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestBrackets()
        {
            string brackets = (string)TestContext.DataRow["Expression"];
            AnalaizerClass.expression = brackets;
            string expected = (string)TestContext.DataRow["ExpectedResult"];
            string actual;
            actual = AnalaizerClass.Format();
            Assert.AreEqual(expected, actual);

        }
    }
}