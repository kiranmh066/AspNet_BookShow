﻿using BookShowBLL.Services;
using BookShowEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace MovieAppCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private MovieService _movieService;

        public MovieController(MovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("GetMovies")]//
        public IEnumerable<Movie> GetMovies()
        {
            return _movieService.GetMovies();
        }

        [HttpPost("AddMovie")]
        public IActionResult AddMovie([FromBody] Movie movie)
        {
            _movieService.AddMovie(movie);
            return Ok("Movie created Successfully");
        }

        [HttpDelete("DeleteMovie")]
        public IActionResult DeleteMovie([FromBody] int movieId)
        {
            _movieService.DeleteMovie(movieId);
            return Ok("Movie deleted Successfully");
        }

        [HttpPut("UpdateMovie")]
        public IActionResult UpdateMovie([FromBody] Movie movie)
        {
            _movieService.UpdateMovie(movie);
            return Ok("Movie Updated Successfully");
        }
    }
}
