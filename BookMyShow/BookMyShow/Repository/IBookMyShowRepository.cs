using BookMyShow.Models;
using BookMyShow.Request;
using BookMyShow.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Controllers;

namespace BookMyShow.Repository
{
    public interface IBookMyShowRepository
    {
        public List<Languages> GetAllLanguages();

        public List<MoviesDTO> GetMoviesBylanguages(int languageId);
        public List<ReviewDTO> GetAllReviewsByMovieId(int movieId);
        public bool PostReview(AddReviewRequest data);
        public bool PostLanguage(AddLanguageRequest data);
        public bool PostMovie(AddMovieRequest data);
        public bool UpdateMovie(UpdateMovieRequest data);


    }
}
