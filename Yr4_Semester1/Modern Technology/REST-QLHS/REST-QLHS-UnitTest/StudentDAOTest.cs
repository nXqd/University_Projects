using REST_QLHS.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using REST_QLHS.Model;
using System.Collections.Generic;

namespace REST_QLHS_UnitTest
{
    
    
    /// <summary>
    ///This is a test class for StudentDAOTest and is intended
    ///to contain all StudentDAOTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StudentDAOTest
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
        ///A test for StudentDAO Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\Dropbox\\dev\\REST-QLHS\\REST-QLHS", "/")]
        [UrlToTest("http://localhost:3978/")]
        public void StudentDAOConstructorTest()
        {
            StudentDAO target = new StudentDAO();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\Dropbox\\dev\\REST-QLHS\\REST-QLHS", "/")]
        [UrlToTest("http://localhost:3978/")]
        public void CreateTest()
        {
            var target = new StudentDAO(); // TODO: Initialize to an appropriate value
            var actual = target.Create(new StudentDTO {Name = "nXqd123123"});
            Assert.AreNotEqual(null, actual);
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\Dropbox\\dev\\REST-QLHS\\REST-QLHS", "/")]
        [UrlToTest("http://localhost:3978/")]
        public void DeleteTest()
        {
            var target = new StudentDAO(); // TODO: Initialize to an appropriate value
            var student = new StudentDTO { Id = 1 }; // TODO: Initialize to an appropriate value
            var actual = target.Delete(student);
            Assert.AreEqual(false, actual.Status);
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\Dropbox\\dev\\REST-QLHS\\REST-QLHS", "/")]
        [UrlToTest("http://localhost:3978/")]
        public void GetTest()
        {
            var target = new StudentDAO(); // TODO: Initialize to an appropriate value
            var actual = target.Get(new StudentDTO{Id = 1});
            Assert.AreNotEqual(null, actual);
        }

        /// <summary>
        ///A test for GetAll
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\Dropbox\\dev\\REST-QLHS\\REST-QLHS", "/")]
        [UrlToTest("http://localhost:3978/")]
        public void GetAllTest()
        {
            var target = new StudentDAO(); // TODO: Initialize to an appropriate value
            var actual = target.GetAll();
            Assert.AreNotEqual(null, actual);
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("D:\\Dropbox\\dev\\REST-QLHS\\REST-QLHS", "/")]
        [UrlToTest("http://localhost:3978/")]
        public void UpdateTest()
        {
            var target = new StudentDAO(); // TODO: Initialize to an appropriate value
            var actual = target.Update(new StudentDTO{Id =1, Name = "asdljk"});
            Assert.AreEqual("asdljk", actual.Name);
        }
    }
}
