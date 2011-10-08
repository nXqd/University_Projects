using System;
using System.Runtime.Serialization;

namespace QLHS_WCF {
    [DataContract]
    public class StudentDTO {
        public StudentDTO() {
            Status = true;
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Fullname { get; set; }

        [DataMember]
        public String Code { get; set; }

        [DataMember]
        public float Avg { get; set; }

        [DataMember]
        public DateTime Birthday { get; set; }

        [DataMember]
        public bool Status { get; set; }
    }
}