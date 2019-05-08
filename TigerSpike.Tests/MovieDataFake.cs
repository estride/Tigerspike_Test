using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using TigerSpike.Entities.Models;
using TigerSpike.Interface.Data;

namespace TigerSpike.Tests
{
    public static class MovieDataFake 
    {
        public static Movie[] _movies;

        static MovieDataFake()
        {           
            _movies = new Movie[]
            {
               new Movie()
               {
                    Id=1,
                    FullImagePath = "https://m.media-amazon.com/images/M/MV5BMTY1OTA2MjI5OV5BMl5BanBnXkFtZTgwNzkxMjU4NjM@._V1_UY209_CR3,0,140,209_AL_.jpg",
                    ThumbnailPath = "https://m.media-amazon.com/images/M/MV5BMTY1OTA2MjI5OV5BMl5BanBnXkFtZTgwNzkxMjU4NjM@._V1_UY209_CR3,0,140,209_AL_.jpg",
                    Title = "Glass",
                    ShortDescription = "Security guard David Dunn uses his supernatural abilities to track Kevin Wendell Crumb, a disturbed man who has twenty-four personalities.",
                    LongDescription = "Security guard David Dunn uses his supernatural abilities to track Kevin Wendell Crumb, a disturbed man who has twenty-four personalities. Director: M. Night Shyamalan | Stars: James McAvoy, Bruce Willis, Samuel L. Jackson, Anya Taylor-Joy. Votes: 117,125 | Gross: $111.04M",
                    ReleaseDate= new DateTime(2019,01,19),
                    Rating = "15+",
                    ScreenTimings = new List<Screen>
                    {
                        new Screen()
                        {
                            Id = 1,
                            ScreeningDateTime = new DateTime(2019,05,08,12,00,00),
                            ScreenName = "Screen 1"
                        },
                         new Screen()
                        {
                            Id = 2,
                            ScreeningDateTime = new DateTime(2019,05,08,14,00,00),
                            ScreenName = "Screen 1"
                        },
                          new Screen()
                        {
                            Id = 3,
                            ScreeningDateTime = new DateTime(2019,05,08,16,00,00),
                            ScreenName = "Screen 1"
                        }
                    }
               },

                new Movie()
               {
                    Id=2,
                    FullImagePath = "https://m.media-amazon.com/images/M/MV5BMTkyOTkwNDc1N15BMl5BanBnXkFtZTgwNzkyMzk3NjM@._V1_UY209_CR0,0,140,209_AL_.jpg",
                    ThumbnailPath = "https://m.media-amazon.com/images/M/MV5BMTkyOTkwNDc1N15BMl5BanBnXkFtZTgwNzkyMzk3NjM@._V1_UY209_CR0,0,140,209_AL_.jpg",
                    Title = "The Lego Movie 2: The Second Part",
                    ShortDescription = "It's been five years since everything was awesome and the citizens are facing a huge new threat: Lego Duplo invaders from outer space, wrecking everything faster than they can rebuild.",
                    LongDescription = "It's been five years since everything was awesome and the citizens are facing a huge new threat: Lego Duplo invaders from outer space, wrecking everything faster than they can rebuild. Director: Mike Mitchell | Stars: Chris Pratt, Elizabeth Banks, Will Arnett, Tiffany Haddish Votes: 26,261 | Gross: $105.80M",
                    ReleaseDate= new DateTime(2019,02,01),
                    Rating = "U",
                     ScreenTimings = new List<Screen>
                    {
                        new Screen()
                        {
                            Id = 4,
                            ScreeningDateTime = new DateTime(2019,05,08,12,00,00),
                            ScreenName = "Screen 2"
                        },
                         new Screen()
                        {
                            Id = 5,
                            ScreeningDateTime = new DateTime(2019,05,08,14,00,00),
                            ScreenName = "Screen 2"
                        }                      
                    }
               },

                 new Movie()
               {
                     Id=3,
                    FullImagePath = "https://m.media-amazon.com/images/M/MV5BMjI5MTQ5NzE4Nl5BMl5BanBnXkFtZTgwNTk2MDA5NjM@._V1_UX140_CR0,0,140,209_AL_.jpg",
                    ThumbnailPath = "https://m.media-amazon.com/images/M/MV5BMjI5MTQ5NzE4Nl5BMl5BanBnXkFtZTgwNTk2MDA5NjM@._V1_UX140_CR0,0,140,209_AL_.jpg",
                    Title = "Wonder Park",
                    ShortDescription = "Wonder Park tells the story of an amusement park where the imagination of a wildly creative girl named June comes alive.",
                    LongDescription = "Wonder Park tells the story of an amusement park where the imagination of a wildly creative girl named June comes alive. Stars: Sofia Mali, Jennifer Garner, Ken Hudson Campbell, Kenan Thompson. Votes: 2,388 | Gross: $45.19M",
                    ReleaseDate= new DateTime(2019,03,05),
                    Rating = "PG",
                      ScreenTimings = new List<Screen>
                    {
                        new Screen()
                        {
                            Id = 6,
                            ScreeningDateTime = new DateTime(2019,05,08,12,00,00),
                            ScreenName = "Screen 3"
                        },
                         new Screen()
                        {
                            Id = 7,
                            ScreeningDateTime = new DateTime(2019,05,08,14,00,00),
                            ScreenName = "Screen 3"
                        }
                    }
               },

                  new Movie()
               {
                      Id=4,
                    FullImagePath = "https://m.media-amazon.com/images/M/MV5BYTJlZWY2YjYtZGIxMy00MDEwLTliNzMtZGM3MDQ1NzlmNDY1XkEyXkFqcGdeQXVyNDY2MjcyOTQ@._V1_UY209_CR0,0,140,209_AL_.jpg",
                    ThumbnailPath = "https://m.media-amazon.com/images/M/MV5BYTJlZWY2YjYtZGIxMy00MDEwLTliNzMtZGM3MDQ1NzlmNDY1XkEyXkFqcGdeQXVyNDY2MjcyOTQ@._V1_UY209_CR0,0,140,209_AL_.jpg",
                    Title = "Glass",
                    ShortDescription = "The true story of the Taj Hotel terrorist attack in Mumbai. Hotel staff risk their lives to keep everyone safe as people make unthinkable sacrifices to protect themselves and their families",
                    LongDescription = "The true story of the Taj Hotel terrorist attack in Mumbai. Hotel staff risk their lives to keep everyone safe as people make unthinkable sacrifices to protect themselves and their families. Director: Anthony Maras | Stars: Dev Patel, Armie Hammer, Nazanin Boniadi, Anupam Kher Votes: 5,496 | Gross: $9.46M",
                    ReleaseDate= new DateTime(2019,03,22),
                    Rating = "15+",
                      ScreenTimings = new List<Screen>
                    {
                        new Screen()
                        {
                            Id = 8,
                            ScreeningDateTime = new DateTime(2019,05,08,18,00,00),
                            ScreenName = "Screen 4"
                        }
                      
                    }
               }
            };
        }
    }
}
