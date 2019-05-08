using System;
using System.Collections.Generic;
using System.Text;
using TigerSpike.Entities.Models;

namespace TigerSpike.Interface.Data
{
    public interface IMovieDataService
    {
        List<Movie> ListAllMovies();
        Movie GetMovieDetails(int id);
        List<Movie> SearchMovies(string title);        
    }
}
