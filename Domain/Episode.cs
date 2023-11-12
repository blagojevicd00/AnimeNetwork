using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Episode
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int Content { get; set; }
        public double ImdbRating { get; set; }
        public ICollection<EpisodeRating> EpisodeRatings { get; set; }
    }
}
