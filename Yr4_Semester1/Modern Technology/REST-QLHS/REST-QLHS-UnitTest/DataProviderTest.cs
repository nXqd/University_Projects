﻿using REST_QLHS.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Data.SQLite;

namespace REST_QLHS_UnitTest
{
    
    
    /// <summary>
    ///This is a test class for DataProviderTest and is intended
    ///to contain all DataProviderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DataProviderTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for DataProvider Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\Dropbox\\dev\\REST-QLHS\\REST-QLHS", "/")]
        [UrlToTest("http://localhost:3978/")]
        public void DataProviderConstructorTest()
        {
            Assert.AreNotEqual(null,DataProvider.Conn);
        }

        /// <summary>
        ///A test for Conn
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\Dropbox\\dev\\REST-QLHS\\REST-QLHS", "/")]
        [UrlToTest("http://localhost:3978/")]
        [DeploymentItem("REST-QLHS.dll")]
        public void ConnTest()
        {
            SQLiteConnection expected = null; // TODO: Initialize to an appropriate value
            SQLiteConnection actual;
            DataProvider_Accessor.Conn = expected;
            actual = DataProvider_Accessor.Conn;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
