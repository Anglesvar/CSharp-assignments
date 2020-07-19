using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.DTO
{
    public class ReviewDTO
    {
        public int reviewId { get; set; }
        public string reviewText { get; set; }
        public string movieName { get; set; }
    }
}
