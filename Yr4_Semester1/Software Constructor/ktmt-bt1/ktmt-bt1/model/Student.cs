using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace ktmt_bt1.model
{
    [DataContract]
    public class Student 
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public float AvgMark  { get; set; }
        [DataMember]
        public bool IsMale { get; set; }


        public static List<Student> GetAll()
        {
            return StudentManager.Students;
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
            return StudentManager.Get(id);
        }
    }

    public class StudentManager
    {
        public static List<Student> Students { get; set; }
        static StudentManager()
        {
            Students = new List<Student>
                       {
                           new Student{Id = 1, Name = "nXqd1", Age = 21, AvgMark = (float) 0.5, IsMale = true},
                           new Student{Id = 2, Name = "nXqd2", Age = 21, AvgMark = (float) 1.5, IsMale = false},
                           new Student{Id = 3, Name = "nXqd3", Age = 21, AvgMark = (float) 2.5, IsMale = true},
                           new Student{Id = 4, Name = "nXqd4", Age = 21, AvgMark = (float) 3.5, IsMale = false},
                           new Student{Id = 5, Name = "nXqd5", Age = 21, AvgMark = (float) 4.5, IsMale = true},
                           new Student{Id = 6, Name = "nXqd6", Age = 21, AvgMark = (float) 5.5, IsMale = true},
                       };
        }

        public static bool Update(Student student)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Id != student.Id) continue;
                Students[i] = student;
                return true;
            }
            return false;
        }

        public static Student Get(int id)
        {
            return Students.FirstOrDefault(student => student.Id == id);
        }
    }

}
