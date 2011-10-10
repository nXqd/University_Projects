using System;

namespace WpfClient.Model
{
    public class StudentDTO {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string Code { get; set; }
        public float Avg { get; set; }
        public DateTime Birthday { get; set; }
    }
}