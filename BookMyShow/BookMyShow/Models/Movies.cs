using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public Languages Languages { get; set; }
        public int LanguagesId { get; internal set; }
    }
}
