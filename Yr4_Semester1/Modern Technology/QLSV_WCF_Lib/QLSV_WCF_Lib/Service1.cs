using System;
using System.Collections.Generic;
using QLHS_WCF;

namespace QLSV_WCF_Lib {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1 {
        private static List<StudentDTO> _studentDatabase;
        private static int _idMax = 11;


        public Service1() {
            // mySQL server tren may em chay hien bi loi nen :(
            _studentDatabase = new List<StudentDTO> {
                                                        new StudentDTO {
                                                                           Id = 0,
                                                                           Avg = 10,
                                                                           Birthday = Convert.ToDateTime("01/01/2010"),
                                                                           Code = "0812090",
                                                                           Fullname = "nXqd"
                                                                       },
                                                        new StudentDTO {
                                                                           Id = 1,
                                                                           Avg = 12,
                                                                           Birthday = Convert.ToDateTime("01/01/2010"),
                                                                           Code = "0812132",
                                                                           Fullname = "nXqd"
                                                                       },
                                                        new StudentDTO {
                                                                           Id = 2,
                                                                           Avg = 15,
                                                                           Birthday = Convert.ToDateTime("01/01/2010"),
                                                                           Code = "0812012",
                                                                           Fullname = "nXqd"
                                                                       },
                                                        new StudentDTO {
                                                                           Id = 3,
                                                                           Avg = 15,
                                                                           Birthday = Convert.ToDateTime("01/01/2010"),
                                                                           Code = "0812012",
                                                                           Fullname = "nXqd"
                                                                       },
                                                        new StudentDTO {
                                                                           Id = 4,
                                                                           Avg = 15,
                                                                           Birthday = Convert.ToDateTime("01/01/201"),
                                                                           Code = "0812012",
                                                                           Fullname = "nXqd"
                                                                       },
                                                        new StudentDTO {
                                                                           Id = 5,
                                                                           Avg = 15,
                                                                           Birthday = Convert.ToDateTime("01/01/2010"),
                                                                           Code = "0812012",
                                                                           Fullname = "nXqd"
                                                                       },
                                                        new StudentDTO {
                                                                           Id = 6,
                                                                           Avg = 15,
                                                                           Birthday = Convert.ToDateTime("01/01/2010"),
                                                                           Code = "0812012",
                                                                           Fullname = "nXqd"
                                                                       },
                                                        new StudentDTO {
                                                                           Id = 7,
                                                                           Avg = 15,
                                                                           Birthday = Convert.ToDateTime("01/01/2010"),
                                                                           Code = "0812012",
                                                                           Fullname = "nXqd"
                                                                       },
                                                        new StudentDTO {
                                                                           Id = 8,
                                                                           Avg = 15,
                                                                           Birthday = Convert.ToDateTime("01/01/2010"),
                                                                           Code = "0812012",
                                                                           Fullname = "nXqd"
                                                                       },
                                                        new StudentDTO {
                                                                           Id = 9,
                                                                           Avg = 15,
                                                                           Birthday = Convert.ToDateTime("01/01/2010"),
                                                                           Code = "0812012",
                                                                           Fullname = "nXqd"
                                                                       },
                                                        new StudentDTO {
                                                                           Id = 10,
                                                                           Avg = 15,
                                                                           Birthday = Convert.ToDateTime("01/01/2010"),
                                                                           Code = "0812012",
                                                                           Fullname = "nXqd"
                                                                       },
                                                        new StudentDTO {
                                                                           Id = 11,
                                                                           Avg = 12,
                                                                           Birthday = Convert.ToDateTime("01/01/2010"),
                                                                           Code = "0812120",
                                                                           Fullname = "nXqd"
                                                                       }
                                                    };
        }

        #region IService1 Members

        public string GetData(int value) {
            return string.Format("You entered: {0}", value);
        }

        public List<StudentDTO> GetAllStudents() {
            var students = new List<StudentDTO>();
            foreach (var student in _studentDatabase) {
                if (student.Status)
                    students.Add(student);
            }
            return students;
        }

        public bool DeleteStudent(StudentDTO student) {
            int index = _studentDatabase.FindIndex(p => p.Id == student.Id);
            if (index >= 0) {
                _studentDatabase[index].Status = false;
                return true;
            }
            return false;
        }

        public bool UpdateStudent(StudentDTO student) {
            int index = _studentDatabase.FindIndex(p => p.Id == student.Id);
            if (index >= 0) {
                _studentDatabase[index] = student;
                return true;
            }
            return false;
        }

        public void CreateStudent(StudentDTO student) {
            _studentDatabase.Add(student);
        }

        public int GetId() {
            return _idMax += 1;
        }

        #endregion
    }
}