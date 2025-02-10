using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Domain.Entities
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieTitle { get; set; }
        public string MovieCoverImageUrl { get; set; }
        public decimal MovieRate { get; set; }
        public string MovieDescription { get; set; }
        public int MovieDuration { get; set; }
        public DateTime MovieReleaseDate { get; set; }
        public string MovieCreatedYear { get; set; }
        public bool MovieStatus { get; set; }
    }
}
