using System.Collections.Generic;

namespace DTO
{
    public class FilmDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string TrailerURI { get; set; }
        public string PosterURI { get; set; }
        public decimal Rating { get; set; }
        public int RateTimes { get; set; }
        public List<string> Genres{ get; set; } /* genres *id */
        public List<string> Details { get; set; } /* time,lang,country,release */
        public List<string> Creators { get; set; } /* creators *id */

    }
}
