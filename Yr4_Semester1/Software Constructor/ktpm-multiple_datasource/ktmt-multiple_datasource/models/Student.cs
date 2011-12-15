using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace ktmt_multiple_datasource.models
{
    [Serializable]
    public class Student
    {
        public int id { get; set; }
        public String full_name { get; set; }
        public String nick_name { get; set; }
        public String grade { get; set; }
        public String subject { get; set; }
        public DateTime birthdate { get; set; }
        public int age { get; set; }
        public String gender { get; set; }

        /// <summary>
        /// public method to get data from a source
        /// </summary>
        /// <param name="src">Name of the source</param>
        /// <returns></returns>
        public static List<Student> get_from(String type,String path) {
            switch (type) {
                case "source1":
                    return source1(path);
                case "source2":
                    return source2(path);
            }
            return null;
        }

        /// <summary>
        /// private method to get data from json 
        /// </summary>
        /// <param name="src">Source file name</param>
        /// <returns></returns>
        private static List<Student> source2(String path)
        {
            var data = XDocument.Load("./data_source/" + path);
            return (from c in data.Descendants("hocsinh")
                    select new Student()
                    {
                        id = Convert.ToInt32(c.Attribute("id").Value),
                        full_name = c.Element("ten_day_du").Value,
                        nick_name = c.Element("bi_danh").Value,
                        grade = c.Element("lop").Value,
                        age = Convert.ToInt32(c.Element("tuoi").Value),
                        birthdate = DateTime.Parse(c.Element("ngay_sinh").Value, new CultureInfo("vi")),
                        gender = c.Element("gioi_tinh").Value,
                        subject = c.Element("mon_hoc").Value,
                    }).ToList();
        }

        /// <summary>
        /// private method to get data from xml 
        /// </summary>
        /// <param name="src">Source file name</param>
        /// <returns></returns>
        private static List<Student> source1(String path)
        {
            var data = XDocument.Load("./data_source/"+path);
            return (from c in data.Descendants("student")
                    select new Student()
                    {
                        id = Convert.ToInt32(c.Attribute("id").Value),
                        full_name = c.Element("full_name").Value,
                        nick_name = c.Element("nick_name").Value,
                        grade = c.Element("grade").Value,
                        age = Convert.ToInt32( c.Element("age").Value),
                        birthdate = DateTime.Parse(c.Element("birthdate").Value,new CultureInfo("vi")),
                        gender = c.Element("gender").Value,
                        subject = c.Element("subject").Value,
                    }).ToList();
        }
    }
}
