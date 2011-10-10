using System;
using System.Runtime.Serialization;

namespace REST_QLHS.Model
{
    /// <summary>
    /// The object used for transfering between database of app
    /// </summary>
    [DataContract]
    public class StudentDTO
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }
        [DataMember(Name = "Name")]
        public string Name { get; set; }
        [DataMember(Name = "Status")]
        public bool Status { get; set; }
        [DataMember(Name = "Code")]
        public string Code { get; set; }
        [DataMember(Name = "Avg")]
        public float Avg { get; set; }
        [DataMember(Name = "Birthday")]
        public DateTime Birthday { get; set; }
        [DataMember(Name = "Image")]
        public String Image { get; set; }
    }
}