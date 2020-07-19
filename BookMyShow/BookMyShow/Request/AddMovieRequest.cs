using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Request
{
    public class AddMovieRequest
    {
        public string MovieName{ get; set; }
        public int LanguageId { get; set; }
    }
}
