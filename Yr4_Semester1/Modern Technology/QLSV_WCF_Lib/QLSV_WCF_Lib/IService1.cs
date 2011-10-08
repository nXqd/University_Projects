using System.Collections.Generic;
using System.ServiceModel;
using QLHS_WCF;

namespace QLSV_WCF_Lib {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1 {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<StudentDTO> GetAllStudents();

        [OperationContract]
        bool DeleteStudent(StudentDTO student);

        [OperationContract]
        bool UpdateStudent(StudentDTO student);

        [OperationContract]
        void CreateStudent(StudentDTO student);

        [OperationContract]
        int GetId();
    }
}