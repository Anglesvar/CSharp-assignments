using BookMyShow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Request
{
    public class AddReviewRequest
    {
        public string Text { get; set; }

        public int MoviesId { get; set; }

    }
}
