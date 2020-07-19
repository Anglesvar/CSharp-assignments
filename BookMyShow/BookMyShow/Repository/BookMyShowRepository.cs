using BookMyShow.Models;
using BookMyShow.Request;
using BookMyShow.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using BookMyShow.Controllers;

namespace BookMyShow.Repository
{
    public class BookMyShowRepository : IBookMyShowRepository
    {
        private readonly ApplicationDbContext _db;

        public BookMyShowRepository(ApplicationDbContext database)
        {
            this._db = database;
        }
        public List<Languages> GetAllLanguages()
        {
            return _db.languages.ToList();
        }

        public List<MoviesDTO> GetMoviesBylanguages(int languageId)
        {
            List<MoviesDTO> moviesByLanguage = new List<MoviesDTO>();
            /*var movies = from moviesList in _db.movies
                         where moviesList.Languages.Id == languageId
                         select moviesList;*/

            // Join Movies with Languages
            List<Movies>joinTable = _db.movies.Include("Languages").Where(a=>a.LanguagesId==languageId).ToList();
            foreach (var movie in joinTable)
            {
                moviesByLanguage.Add(new MoviesDTO 
                { 
                    MovieName = movie.MovieName,
                    Id = movie.Id,
                    languageName = movie.Languages.LanguageName,
                    LanguageId = languageId
                });
            }
            return moviesByLanguage;
        }
        public bool PostLanguage(AddLanguageRequest data)
        {            
            List<Languages> languageExists;
            languageExists = _db.languages.Where(a => a.LanguageName.ToLower() == data.LanguageName.ToLower()).ToList();
            if (languageExists.Count == 0) //Condition to Check if the language requested to add already exists or not
            {
                if (data != null)
                {
                    Languages languages = new Languages();
                    languages.LanguageName = data.LanguageName;
                    _db.languages.Add(languages);
                    _db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        public bool PostMovie(AddMovieRequest data)
        {
            List<Movies> movie;
            movie = _db.movies.Where(a => a.MovieName.ToLower() == data.MovieName.ToLower()).ToList();
            if (movie.Count == 0) //Condition to Check if the movie requested to add already exists or not
            {
                if (data != null)
                {
                    Movies movies = new Movies();
                    movies.MovieName = data.MovieName;
                    movies.LanguagesId = data.LanguageId;
                    return true;
                }
            }
            return false;
        }
        public bool PostReview(AddReviewRequest data)
        {

            if (data != null)
            {                        
                Review reviewObj = new Review();
                reviewObj.ReviewText = data.Text;
                reviewObj.MoviesId = data.MoviesId;
                _db.reviews.Add(reviewObj);
                _db.SaveChanges();
                return true;
            }   
            return false;
        }
        public bool UpdateMovie(UpdateMovieRequest data)
        {
            var movie = _db.movies.Where(a => a.Id == data.id).FirstOrDefault();
            if (movie != null && data!=null)
            {
                movie.MovieName = string.IsNullOrEmpty(data.MovieName) ? movie.MovieName : data.MovieName;
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<ReviewDTO> GetAllReviewsByMovieId(int movieId)
        {
            List<ReviewDTO> reviewData = new List<ReviewDTO>();
            /*List<ReviewDTO> reviewByMovie = new List<ReviewDTO>();
            var allReviews = from reviewText in _db.reviews
                         where reviewText.Movies.Id == movieId
                         select reviewText;*/
            List<Review> allReviews = _db.reviews.Include("Movies").Where(a => a.MoviesId == movieId).ToList();

            foreach (var review in allReviews)
            {
                reviewData.Add(new ReviewDTO
                {
                    reviewId = review.Id,
                    reviewText = review.ReviewText,
                    movieName = review.Movies.MovieName
                });
            }
            return reviewData;
        }
    }
}
