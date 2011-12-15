using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using Newtonsoft.Json;
using ktmt_bt1.model;

namespace ktmt_bt1
{
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]

    public class Service1
    {
        [OperationContract]
        [WebGet(UriTemplate = "getAll",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public List<Student> GetCollection()
        {
            return Student.GetAll();
        }

        [WebGet(UriTemplate = "student/{id}",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public Student Get(string id)
        {
            return Student.Get(Convert.ToInt32(id));
        }

        [WebInvoke(UriTemplate = "student/update", Method = "PUT",
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        public bool Update(Stream s)
        {
            try
            {
                Student student;
                using ( var reader = new StreamReader(s)) {
                    var res = reader.ReadToEnd();
                    reader.Close();
                    reader.Dispose();
                    student = JsonConvert.DeserializeObject<Student>(res);
                    StudentManager.Update(student);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
