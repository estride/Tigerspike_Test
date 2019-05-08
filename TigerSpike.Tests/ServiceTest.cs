using AutoFixture;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using TigerSpike.Core;
using TigerSpike.Data;
using TigerSpike.Entities.Models;
using TigerSpike.Interface.Data;
using Xunit;

namespace TigerSpike.Tests
{
    public class ServiceTest
    {       

        [Fact]
        public void GetAllMovies_CountReturned_3()
        {
            var dbContextOptionsBuilder = new DbContextOptionsBuilder<TSContext>();

            dbContextOptionsBuilder.UseSqlServer("Mock", opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));


            var mockedContext = new Mock<TSContext>(dbContextOptionsBuilder.Options);
            mockedContext.Setup(c => c.Movies).ReturnsDbSet(MovieDataFake._movies);
            MovieDataService s = new MovieDataService(mockedContext.Object);

            var m = s.ListAllMovies();

            Assert.Equal(4, m.Count);

        }

        [Fact]
        public void GetMovieById_ReturnNull()
        {
            var mockedContext = new Mock<TSContext>();
            mockedContext.Setup(c => c.Movies).ReturnsDbSet(MovieDataFake._movies);
            MovieDataService s = new MovieDataService(mockedContext.Object);

            var m = s.GetMovieDetails(10);

            Assert.Null(m);

        }


        [Fact]
        public void GetMovieById_ReturnMovie()
        {
            var mockedContext = new Mock<TSContext>();
            mockedContext.Setup(c => c.Movies).ReturnsDbSet(MovieDataFake._movies);
            MovieDataService s = new MovieDataService(mockedContext.Object);

            var m = s.GetMovieDetails(1);

            Assert.Equal("Glass", m.Title);

        }

        [Fact]
        public void GetMovieById_SearchMovie()
        {
            var mockedContext = new Mock<TSContext>();
            mockedContext.Setup(c => c.Movies).ReturnsDbSet(MovieDataFake._movies);
            MovieDataService s = new MovieDataService(mockedContext.Object);

            var m = s.SearchMovies("Glass");

            Assert.Equal("Glass", m.Find(t=>t.Title == "Glass").Title);

        }
    }
}
