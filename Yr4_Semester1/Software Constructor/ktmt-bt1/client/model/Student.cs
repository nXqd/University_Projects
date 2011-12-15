using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Microsoft.Http;
using Newtonsoft.Json;

namespace client.model
{
    public class Student 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float AvgMark  { get; set; }
        public bool IsMale { get; set; }


        public static List<Student> GetAll()
        {
            return null;
        }

        public static bool Update(Student student)
        {
            try
            {
                StudentManager.Update(student);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static Student Get(int id)
        {
            return GetAll().FirstOrDefault(student => student.Id == id);
        }
    }

    public class StudentManager
    {
        private static String ServiceURL;
        public static String Port
        {
            set
            {
                ServiceURL = "http://localhost:" + value + "/StudentService/";
            }
        }

        public static List<Student> GetAll()
        {
            try
            {
                var webClient = new WebClient();
                var json = webClient.DownloadString(ServiceURL + "getAll");
                return JsonConvert.DeserializeObject<List<Student>>(json);
            } catch(Exception)
            {
                return null;
            }
        }

        public static bool Update(Student student)
        {
            var http = new HttpClient(ServiceURL);
            var uri = "student/update";
            
            // get return string from server
            var res = http.Put(uri, HttpContent.Create(JsonConvert.SerializeObject(student)));
            var stream = res.Content.ReadAsStream();
            var result = new StreamReader(stream).ReadToEnd();
            if (result == "true")
                return true;
            return false;
        }
    }

}
