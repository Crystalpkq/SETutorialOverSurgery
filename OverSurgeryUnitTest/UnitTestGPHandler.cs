using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OverSurgery;

namespace OverSurgeryUnitTest
{
    /// <summary>
    /// Summary description for UnitTestGPHandler
    /// </summary>
    [TestClass]
    public class UnitTestGPHandler
    {
        public UnitTestGPHandler()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestAddNewGP()
        {
            DbConnector dbC = new DbConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            GeneralPractitioner gp = new GeneralPractitioner();

            gp.Name = "Hector Barbossa";
            gp.Status = 1;
            gp.DateJoined = new DateTime(2017, 1, 15, 0, 0, 0);
            gp.LoginName = "hector";
            gp.Password = "hector123";

            GPHandler gpHnd = new GPHandler();
            int resp2 = gpHnd.addNewGP(dbC.getConn(), gp);
            Assert.IsNotNull(resp2);
        }
    }
}





