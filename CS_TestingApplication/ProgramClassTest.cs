using System;
using System.IO;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;

namespace CS_TestingApplication
{
    [TestClass]
    public class ProgramClassTest
    {
        [TestMethod]
        public void MainTestMethod()
        {
            // Arrange
            // Collect the Input Data / Infrastructure object / Dependencies 
            // required to execute the test
            // 1. Hard-Coded values
            // 2. Instance of class of which method to be unit tested
            // 3. MOQ Object creation aka Fake Object
            const string Expected = "Hello World";

            // Act
            // Actual perform the method call that is to be tested
            // pass parameters / Managed Exceptions / Handle Events
            string Actual = "";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                CS_ApplicationForTesting.Program.Main();
                Actual = sw.ToString().Trim();
            }

            // Assert
            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void CheckValueFalseTest()
        {
            // arrange
            int x = -9;
            var actual = CS_ApplicationForTesting.Program.CheckValue(x);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CheckValueTrueTest()
        {
            // arrange
            int x = 19;
            var actual = CS_ApplicationForTesting.Program.CheckValue(x);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void LoginStatusTest()
        {
            string uname = "A1";
            string pwd = "P1";

            var res = CS_ApplicationForTesting.Program.Login(uname,pwd);
            Assert.IsTrue(res);

        }

        [DataTestMethod]
        [DataRow("A1", "P1")] // Pre Test Code
        [DataRow("A2", "P2")] // Pre Test Code
        [DataRow("A3", "P2")] // Pre Test Code
        public void LoginStatusDataDriveTest(string uname, string pwd)
        {
            var res = CS_ApplicationForTesting.Program.Login(uname, pwd);
            Assert.IsTrue(res);

        }
    }
  
}
