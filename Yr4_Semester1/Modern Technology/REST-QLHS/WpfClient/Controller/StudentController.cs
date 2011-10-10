#region using region

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Xml.Linq;
using WpfClient.Model;

#endregion

namespace WpfClient.Controller {
    public class StudentController {
        private const String ServiceURL = "http://localhost:3978/Service1/";
        private static readonly XNamespace Namespace = "http://schemas.datacontract.org/2004/07/REST_QLHS.Model";


        private static String GetXmlGetAll() {
            var webClient = new WebClient();
            return webClient.DownloadString(ServiceURL + "students");
        }

        public static string Create(StudentDTO dto, string imageFile) {
            var request = WebRequest.Create(ServiceURL + "students/create") as HttpWebRequest;
            return GetPostResult(dto, request, imageFile);
        }

        public static string Update(StudentDTO dto, string imageFile) {
            var request = WebRequest.Create(ServiceURL + "students/update") as HttpWebRequest;
            return GetPostResult(dto,request, imageFile);
        }

        private static string GetPostResult(StudentDTO dto, HttpWebRequest request, string imageFileAddress) {

            // Upload image to server
            PostImage(dto, imageFileAddress);

            // Set type to POST  
            var result = PostOtherData(dto, request);
            return result;
        }

        private static string PostOtherData(StudentDTO dto, HttpWebRequest request) {
            if (request != null) {
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentType = "application/json";
            }

            // Create a byte array of the data we want to send  
            var byteData = Encoding.UTF8.GetBytes(
                "{'Id' : '" + dto.Id + "','Name' : '" + dto.Name + "', 'Status' : '" + dto.Status + "',  'Code': '" + dto.Code +
                "', 'Avg' : " + dto.Avg + ", 'Birthday' : '" + dto.Birthday + "'}"
                );

            // Set the content length in the request headers  
            request.ContentLength = byteData.Length;

            // Write data  
            using (var postStream = request.GetRequestStream())
                postStream.Write(byteData, 0, byteData.Length);

            // Get response  
            string result;
            try {
                using (var response = request.GetResponse() as HttpWebResponse)
                    result = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch {
                result = "failed";
            }
            return result;
        }

        private static void PostImage(StudentDTO dto, string filePath)
        {
            var request = (HttpWebRequest)WebRequest.Create(ServiceURL + "students/upload/" + dto.Name);

            request.Accept = "text/xml";
            request.Method = "POST";
            request.ContentType = "image/jpeg";
            using (var fileStream = File.OpenRead(filePath))
            using (var requestStream = request.GetRequestStream()) {
                var buffer = new byte[1024];
                int byteCount;
                while ((byteCount = fileStream.Read(buffer, 0, 1024)) > 0) {
                    requestStream.Write(buffer, 0, byteCount);
                }
            }
            string result;
            try
            {
                var response = request.GetResponse();
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception exception) {
                MessageBox.Show("Your image size is too big !");
            }
        }

        public static Stream GetImage(string name) {
            Stream stream = null;
            try {
                var webClient = new WebClient();
                stream = webClient.OpenRead(ServiceURL + "students/image/" +name);
            } catch (WebException) {
            }
            return stream;
        }

        public static List<StudentDTO> GetAll() {

            var xml = GetXmlGetAll();
            var xdoc = XDocument.Parse(xml);
            var students = from t in xdoc.Descendants(Namespace + "StudentDTO")
                           select new StudentDTO {
                                                     Id = Convert.ToInt32( t.Element(Namespace + "Id").Value),
                                                     Name = t.Element(Namespace + "Name").Value,
                                                     Avg = Convert.ToSingle( t.Element(Namespace + "Avg").  Value),
                                                     Status = Convert.ToBoolean( t.Element(Namespace + "Status").  Value),
                                                     Code = t.Element(Namespace + "Code").Value,
                                                     Birthday = Convert.ToDateTime( t.Element(Namespace + "Birthday") .Value)
                                                 };
            return new List<StudentDTO>(students);
        }

        public static string Delete(StudentDTO dto) {
            // TODO: Change to normal get for better performance
            var request = WebRequest.Create(ServiceURL + "students/" + dto.Id + "/delete") as HttpWebRequest;
            return GetPostResult(dto,request, null);
        }

        /// <summary>
        /// Convert file from address to byteArray
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static byte[] FileToByteArray(string fileName) {
            byte[] buffer = null;

            try {
                // Open file for reading
                var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                // attach filestream to binary reader
                var binaryReader = new BinaryReader(fileStream);

                // get total byte length of the file
                var totalBytes = new FileInfo(fileName).Length;

                // read entire file into buffer
                buffer = binaryReader.ReadBytes((Int32)totalBytes);

                // close file reader
                fileStream.Close();
                fileStream.Dispose();
                binaryReader.Close();
            } catch (Exception exception) { Console.WriteLine(@"Exception caught in process: {0}", exception); }

            return buffer;
        }
    }
}