using wTickets.Data.@enum;
using wTickets.Models;

namespace wTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<dbContext>();
                context.Database.EnsureCreated();

                if (!context.Cinema.Any())
                {
                    context.Cinema.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            cinemaName = "Cinema 1",
                            logo = "https://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            cinemaDescription = "This is description for cinema 1"
                        },
                        new Cinema()
                        {
                            cinemaName = "Cinema 2",
                            logo = "https://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            cinemaDescription = "This is description for cinema 2"
                        },
                        new Cinema()
                        {

                            cinemaName = "Cinema 3",
                            logo = "https://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            cinemaDescription = "This is description for cinema 4"
                        },
                        new Cinema()
                        {
                            cinemaName = "Cinema 4",
                            logo = "https://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            cinemaDescription = "This is description for cinema 4"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Actor.Any())
                {
                    context.Actor.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            actorName = "Actor 1",
                            Bio = "This is the Bio of first actor",
                            profilePicURL = "https://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor()
                        {
                            actorName = "Actor 2",
                            Bio = "This is the Bio of second actor",
                            profilePicURL = "https://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            actorName = "Actor 3",
                            Bio = "This is the Bio of third actor",
                            profilePicURL = "https://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            actorName = "Actor 4",
                            Bio = "This is the Bio of forth actor",
                            profilePicURL = "https://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            actorName = "Actor 5",
                            Bio = "This is the Bio of fifth actor",
                            profilePicURL = "https://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Producer.Any())
                {
                    context.Producer.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            producerName = "Producer 1",
                            Bio = "This is the Bio of first Producer",
                            profilePicURL = "https://dotnethow.net/images/Producers/Producer-1.jpeg"
                        },
                        new Producer()
                        {
                            producerName = "Producer 2",
                            Bio = "This is the Bio of second Producer",
                            profilePicURL = "https://dotnethow.net/images/Producers/Producer-2.jpeg"
                        },
                        new Producer()
                        {
                            producerName = "Producer 3",
                            Bio = "This is the Bio of third Producer",
                            profilePicURL = "https://dotnethow.net/images/Producers/Producer-3.jpeg"
                        },
                        new Producer()
                        {
                            producerName = "Producer 4",
                            Bio = "This is the Bio of forth Producer",
                            profilePicURL = "https://dotnethow.net/images/Producers/Producer-4.jpeg"
                        },
                        new Producer()
                        {
                            producerName = "Producer 5",
                            Bio = "This is the Bio of fifth Producer",
                            profilePicURL = "https://dotnethow.net/images/Producers/Producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            movieName = "Life",
                            description = "This is the Life movie description",
                            price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            movieStartDate = DateTime.Now.AddDays(-10),
                            movieEndDate = DateTime.Now.AddDays(10),
                            cinemaId = 3,
                            producerId = 3,
                            category = movieCategory.Documentary
                        },
                        new Movie()
                        {
                            movieName = "The Shawshank Redemption",
                            description = "This is the Shawshank Redemption description",
                            price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            movieStartDate = DateTime.Now,
                            movieEndDate = DateTime.Now.AddDays(3),
                            cinemaId = 1,
                            producerId = 1,
                            category = movieCategory.Action
                        },
                        new Movie()
                        {
                            movieName = "Ghost",
                            description = "This is the Ghost movie description",
                            price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            movieStartDate = DateTime.Now,
                            movieEndDate = DateTime.Now.AddDays(7),
                            cinemaId = 4,
                            producerId = 4,
                            category = movieCategory.Horror
                        },
                        new Movie()
                        {
                            movieName = "Race",
                            description = "This is the Race movie description",
                            price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            movieStartDate = DateTime.Now.AddDays(-10),
                            movieEndDate = DateTime.Now.AddDays(-5),
                            cinemaId = 1,
                            producerId = 2,
                            category = movieCategory.Documentary
                        },
                        new Movie()
                        {
                            movieName = "Scoob",
                            description = "This is the Scoob movie description",
                            price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            movieStartDate = DateTime.Now.AddDays(-10),
                            movieEndDate = DateTime.Now.AddDays(-2),
                            cinemaId = 1,
                            producerId = 3,
                            category = movieCategory.Cartoon
                        },
                        new Movie()
                        {
                            movieName = "Cold Soles",
                            description = "This is the Cold Soles movie description",
                            price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            movieStartDate = DateTime.Now.AddDays(3),
                            movieEndDate = DateTime.Now.AddDays(20),
                            cinemaId = 1,
                            producerId = 5,
                            category = movieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Actor_Movie.Any())
                {
                    context.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            actorId = 1,
                            movieId = 1
                        },
                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 1
                        },

                         new Actor_Movie()
                        {
                            actorId = 1,
                            movieId = 2
                        },
                         new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 2
                        },

                        new Actor_Movie()
                        {
                            actorId = 1,
                            movieId = 3
                        },
                        new Actor_Movie()
                        {
                            actorId = 2,
                            movieId = 3
                        },
                        new Actor_Movie()
                        {
                            actorId = 5,
                            movieId = 3
                        },


                        new Actor_Movie()
                        {
                            actorId = 2,
                            movieId = 4
                        },
                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 4
                        },
                        new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 4
                        },


                        new Actor_Movie()
                        {
                            actorId = 2,
                            movieId = 5
                        },
                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 5
                        },
                        new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 5
                        },
                        new Actor_Movie()
                        {
                            actorId = 5,
                            movieId = 5
                        },


                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 6
                        },
                        new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 6
                        },
                        new Actor_Movie()
                        {
                            actorId = 5,
                            movieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
