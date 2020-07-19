using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.DTO
{
    public class MoviesDTO
    {
        public int Id { get; set; }
        public string languageName { get; set; }
        public string MovieName { get; set; }
        public int LanguageId { get; set; }
    }
}
