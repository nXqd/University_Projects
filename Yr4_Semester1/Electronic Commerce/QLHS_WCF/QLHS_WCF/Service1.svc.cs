using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace QLHS_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value) { return string.Format("You entered: {0}", value); }
        private static List<StudentDTO> _studentDatabase;


        public Service1() {
            // mySQL server tren may em chay hien bi loi nen :(
            _studentDatabase = new List<StudentDTO> {
                                                        new StudentDTO() { Id = 0, Avg = 10, Birthday = Convert.ToDateTime("01/01/2010"), Code = "0812090", Fullname = "nXqd" },
                                                        new StudentDTO() { Id = 1, Avg = 12, Birthday = Convert.ToDateTime("01/01/2010"), Code = "0812132", Fullname = "nXqd" },
                                                        new StudentDTO() { Id = 2, Avg = 15, Birthday = Convert.ToDateTime("01/01/2010"), Code = "0812012", Fullname = "nXqd" },
                                                        new StudentDTO() { Id = 3, Avg = 15, Birthday = Convert.ToDateTime("01/01/2010"), Code = "0812012", Fullname = "nXqd" },
                                                        new StudentDTO() { Id = 4, Avg = 15, Birthday = Convert.ToDateTime("01/01/201"), Code = "0812012", Fullname = "nXqd" },
                                                        new StudentDTO() { Id = 5, Avg = 15, Birthday = Convert.ToDateTime("01/01/2010"), Code = "0812012", Fullname = "nXqd" },
                                                        new StudentDTO() { Id = 6, Avg = 15, Birthday = Convert.ToDateTime("01/01/2010"), Code = "0812012", Fullname = "nXqd" },
                                                        new StudentDTO() { Id = 7, Avg = 15, Birthday = Convert.ToDateTime("01/01/2010"), Code = "0812012", Fullname = "nXqd" },
                                                        new StudentDTO() { Id = 8, Avg = 15, Birthday = Convert.ToDateTime("01/01/2010"), Code = "0812012", Fullname = "nXqd" },
                                                        new StudentDTO() { Id = 9, Avg = 15, Birthday = Convert.ToDateTime("01/01/2010"), Code = "0812012", Fullname = "nXqd" },
                                                        new StudentDTO() { Id = 10, Avg = 15, Birthday = Convert.ToDateTime("01/01/2010"), Code = "0812012", Fullname = "nXqd" },
                                                        new StudentDTO() { Id = 11, Avg = 12, Birthday = Convert.ToDateTime("01/01/2010"), Code = "0812120", Fullname = "nXqd" }
                                                    };
        }

        public List<StudentDTO> GetAllStudents() {
            return _studentDatabase;
        }

        public bool DeleteStudent(StudentDTO student) {
            var index = _studentDatabase.FindIndex(p => p.Id == student.Id);
            if (index >= 0) {
                _studentDatabase[index].Status = false;
                return true;
            }
            return false;
        }

        public bool UpdateStudent(StudentDTO student) {
            var index = _studentDatabase.FindIndex(p => p.Id == student.Id);
            if (index >= 0) {
                _studentDatabase[index] = student;
                return true;
            }
            return false;
        }

        public void CreateStudent(StudentDTO student) {
            _studentDatabase.Add(student);

        }
    }
}
