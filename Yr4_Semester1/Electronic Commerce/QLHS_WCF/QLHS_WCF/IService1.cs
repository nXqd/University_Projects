using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace QLHS_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

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
    }
}
