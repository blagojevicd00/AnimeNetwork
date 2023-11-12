using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Rating
    {
        public int Id { get; set; }
        public int Stars { get; set; }
        public ICollection<EpisodeRating> EpisodeRatings { get; set; }
    }
}
