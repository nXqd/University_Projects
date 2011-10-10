using System.Net;
using System.Text;
using REST_QLHS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.IO;
using REST_QLHS.Model;

namespace REST_QLHS_UnitTest
{
    
    
    /// <summary>
    ///This is a test class for Service1Test and is intended
    ///to contain all Service1Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Service1Test
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
            Service1 target = new Service1(); // TODO: Initialize to an appropriate value
            // Create the web request  
            var request = WebRequest.Create("http://localhost:3978/Service1/" + "students/create") as HttpWebRequest;
            var dto = new StudentDTO {Name = "nXqd", Avg = (float) 10.1, Code = "0812090"};

            // Set type to POST  
            if (request != null)
            {
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentType = "application/json";
            }

            // Create a byte array of the data we want to send  
            var byteData = Encoding.UTF8.GetBytes(
                "{\"Name\":\"" + dto.Name + "\"," +
                 "\"Code\":\"" + dto.Code + "\"," +
                 "\"Status\":\"" + dto.Status + "\"," +
                 "\"Avg\":\"" + dto.Avg + "\"," +
                 "\"Birthday\":\"" + dto.Birthday + "\",}"
            );

            // Set the content length in the request headers  
            request.ContentLength = byteData.Length;

            // Write data  
            using (var postStream = request.GetRequestStream())
            {
                postStream.Write(byteData, 0, byteData.Length);
            }

            // Get response  
            using (var response = request.GetResponse() as HttpWebResponse)
            {
                // Get the response stream  
                var reader = new StreamReader(response.GetResponseStream());
            }
            // Assert.AreEqual(expected, actual);
        }
    }
}
