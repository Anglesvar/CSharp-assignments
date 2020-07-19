using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Models;
using BookMyShow.Repository;
using BookMyShow.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IBookMyShowRepository repository;

        public MoviesController(IBookMyShowRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("languages")]
        public IActionResult GetAllLanguages()
        {
            return Ok(repository.GetAllLanguages());
        }

        [HttpGet("movies/{id}")]
        public IActionResult GetMoviesBylanguages(int id)
        {
            return Ok(repository.GetMoviesBylanguages(id));
        }

        [HttpPost]
        [Route("AddReview")]
        public IActionResult PostReview(AddReviewRequest data)
        {
            return Ok(repository.PostReview(data));
        }

        [HttpGet("reviews")]
        public IActionResult GetReviews(int id)
        {
            return Ok(repository.GetAllReviewsByMovieId(id));
        }

        [HttpPost]
        [Route("AddLanguage")]
        public IActionResult PostLanguage(AddLanguageRequest data)
        {
            return Ok(repository.PostLanguage(data));
        }

        [HttpPost]
        [Route("AddMovie")]
        public IActionResult PostMovie(AddMovieRequest data)
        {
            return Ok(repository.PostMovie(data));
        }

        [HttpPut]
        [Route("UpdateMovie")]
        public IActionResult UpdateMove(UpdateMovieRequest data)
        {
            return Ok(repository.UpdateMovie(data));
        }
    }
}

