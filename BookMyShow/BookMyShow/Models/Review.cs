using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string ReviewText { get; set; }
        public Movies Movies { get; set; }
        public int MoviesId { get; internal set; }
    }
}
