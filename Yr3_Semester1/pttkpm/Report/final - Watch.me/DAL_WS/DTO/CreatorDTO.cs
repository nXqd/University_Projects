using System.Collections.Generic;

namespace DTO
{
    public class CreatorDTO
    {
        public string CreatorName { get; set; }
        public string CreatorBirth { get; set; }
        public string CreatorTravia { get; set; }
        public List<string> CreatorTypes { get; set; } // types *id
        public List<string> OtherDetails { get; set; }
    }
}
