using BookMyShow.Request;

namespace BookMyShow.Controllers
{
    
    public class UpdateMovieRequest : AddMovieRequest
    {
        public int id { get; set; }
    }
    
}