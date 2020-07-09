using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS_TestingApplication
{
    [TestClass]
    public class DataDrivenTest
    {
        // define the TestContext

        private TestContext _Context;

        public TestContext TestContext
        {
            get { return _Context;  }
            set { _Context = value; }
        }

        [TestMethod]
        [DataSource("System.Data.SqlClient", "Server=.;Database=AppDbApi;Integrated Security=SSPI", 
            "UsersTestData",
            DataAccessMethod.Sequential)] 
        public void LoginStatusTest()
        {
            // Read the Data from the Data Source under the TestContext
            string uname = TestContext.DataRow["UserName"].ToString();
            string pwd = TestContext.DataRow["Password"].ToString();
            bool expectedLoginStatus = Convert.ToBoolean(TestContext.DataRow["LoginStatus"]);

            bool actual = CS_ApplicationForTesting.Program.Login(uname, pwd);
            Assert.AreEqual(expectedLoginStatus, actual);
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"E:\Fujitsu\SpotDemos\MyTestingApps\CS_TestingApplication\bin\Debug\data.csv", "data#csv",
            DataAccessMethod.Sequential),DeploymentItem("data.csv")]
        public void LoginStatusCSVTest()
        {
            // Read the Data from the Data Source under the TestContext
            string uname = TestContext.DataRow["UserName"].ToString();
            string pwd = TestContext.DataRow["Password"].ToString();
            bool expectedLoginStatus = Convert.ToBoolean(TestContext.DataRow["LoginStatus"]);

            bool actual = CS_ApplicationForTesting.Program.Login(uname, pwd);
            Assert.AreEqual(expectedLoginStatus, actual);
        }
    }
}
