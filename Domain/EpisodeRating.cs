using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class EpisodeRating
    {
        public Episode Episode { get; set; }
        public int EpisodeId { get; set; }
        public Rating Rating { get; set; }
        public int RatingId { get; set; }
    }
}
