using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Web.Script.Serialization;
using REST_QLHS.Data;
using REST_QLHS.Model;

namespace REST_QLHS
{
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    // NOTE: If the service is renamed, remember to update the global.asax.cs file
    public class Service1
    {
        private static readonly StudentDAO DAO = new StudentDAO();
        private static readonly string CurrentPath = AppDomain.CurrentDomain.BaseDirectory;


        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns>Return the list of students </returns>
        [WebGet(UriTemplate = "students")]
        public List<StudentDTO> GetCollection() {
            return DAO.GetAll();
        }

        /// <summary>
        /// Get all students
        /// </summary>
        /// <returns>Return the list of students </returns>
        [WebGet(UriTemplate = "students/image/{name}")]
        public Stream GetImage(string name) {
            var fs = File.OpenRead(CurrentPath + @"res\image\" + name + ".jpg");
            if (WebOperationContext.Current != null)
                WebOperationContext.Current.OutgoingResponse.ContentType = "image/jpeg";
            return fs;
        }

        /// <summary>
        /// Get students by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the StudentDTO</returns>
        [WebInvoke(UriTemplate = "students/{id}", Method = "GET")]
        public StudentDTO Get(string id) {
            return id != null ? DAO.Get(new StudentDTO {Id = int.Parse(id)}) : null;
        }

        /// <summary>
        /// Create student 
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Return "success" or "failed"</returns>
        [WebInvoke(UriTemplate = "students/create", Method = "POST")]
        public string Create(Stream input) {
            return ProcessPostResult(input, "Create");
        }

        /// <summary>
        /// Update student 
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Return "success" or "failed"</returns>
        [WebInvoke(UriTemplate = "students/update", Method = "POST")]
        public string Update(Stream input) { return ProcessPostResult(input, "Update"); }

        /// <summary>
        /// Update student 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="fileStream"></param>
        /// <returns>Return "success" or "failed"</returns>
        [WebInvoke(UriTemplate = "students/upload/{filename}", Method = "POST")]
        public void ImageUpload(string fileName, Stream fileStream) {
            var fileToUpload = new FileStream(CurrentPath + @"res\image\" + fileName + ".jpg", FileMode.Create);

            var bytearray = new byte[10000];
            int bytesRead;
            do {
                bytesRead = fileStream.Read(bytearray, 0, bytearray.Length);
            } while (bytesRead > 0);

            fileToUpload.Write(bytearray, 0, bytearray.Length);
            fileToUpload.Close();
            fileToUpload.Dispose();
        }

        /// <summary>
        /// /Delete student
        /// </summary>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <returns>Return "success" or "failed"</returns>
        [WebInvoke(UriTemplate = "students/{id}/delete", Method = "POST")]
        public string Delete(string id, Stream input) {
            try {
                if (DAO.Delete(new StudentDTO {Id = Convert.ToInt32(id)}) == null)
                    return "failed";
            }
            catch {
                return "failed";
            }
            return "success";
        }

        /// <summary>
        /// Deserialize the json post and return the reult of it
        /// </summary>
        /// <param name="input"></param>
        /// <param name="type"></param>
        /// <returns>Return "success" or "failed"</returns>
        private static string ProcessPostResult(Stream input,string type) {
            var reader = new StreamReader(input);
            var json = reader.ReadToEnd();
            var serializer = new JavaScriptSerializer();

            try {
                var dto = serializer.Deserialize<StudentDTO>(json);
                Object o;
                switch (type) {
                    case "Update": o = DAO.Update(dto); break;
                    default: 
                        // Upload image
                        var fileToUpload = new FileStream(CurrentPath + @"res\image\" + dto.Image, FileMode.Create);
                        var bytes = new byte[10000];
                        fileToUpload.Write(bytes, 0, bytes.Length);
                        fileToUpload.Close();
                        fileToUpload.Dispose();

                        // Create this object in database
                        o = DAO.Create(dto); 
                        break;
                }
                if (o == null) {
                    return "failed";
                }
            } catch { return "failed"; }
            return "success";
        }
    }
}
