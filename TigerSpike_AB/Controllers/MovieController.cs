using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TigerSpike.Entities.Models;
using TigerSpike.Interface.Data;

namespace TigerSpike_AB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieDataService _service;

        public MovieController(IMovieDataService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get list of all movie title and timings
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<Movie>), 200)]        
        public ActionResult<List<Movie>> Get()
        {
            var _movies = _service.ListAllMovies();
            return Ok(_movies);
        }

        /// <summary>
        /// Search movie by title
        /// </summary>
        /// <param name="title">enter movie title</param>
        /// <returns>Movie</returns>
        [HttpGet("{title}")]
        [ProducesResponseType(typeof(Movie), 200)]
        public ActionResult<Movie> Get(string title)
        {
            var _movie = _service.SearchMovies(title);
            return Ok(_movie);
        }

        /// <summary>
        /// Get movie by id
        /// </summary>
        /// <param name="id">Movie id</param>
        [HttpPost]
        [ProducesResponseType(typeof(List<Movie>), 200)]
        public ActionResult<List<Movie>> Post([FromBody] int id)
        {
            var _movies = _service.GetMovieDetails(id);

            if (_movies == null)
                return NotFound();

            return Ok(_movies);
        }

    }
}
