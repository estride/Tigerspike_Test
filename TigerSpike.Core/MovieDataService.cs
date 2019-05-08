using System;
using System.Collections.Generic;
using System.Linq;
using TigerSpike.Data;
using TigerSpike.Entities.Models;
using TigerSpike.Interface.Data;

namespace TigerSpike.Core
{
    public class MovieDataService : IMovieDataService
    {
        private readonly TSContext _context;

        public MovieDataService(TSContext context)
        {
            _context = context;
        }

        public Movie GetMovieDetails(int id)
        {
            return _context.Movies.Where(t => t.Id == id).FirstOrDefault();
        }

        public List<Movie> ListAllMovies()
        {
            return _context.Movies.ToList();
        }

        public List<Movie> SearchMovies(string title)
        {
            return _context.Movies.Where(t => t.Title == title).ToList();


        }
    }
}
