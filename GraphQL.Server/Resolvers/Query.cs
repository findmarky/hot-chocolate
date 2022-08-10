using GraphQL.Server.Data;
using GraphQL.Server.Models;

namespace GraphQL.Server.Resolvers
{
    public class Query
    {
        public List<Movie> GetMovies() => Seed.Movies;

        public Movie? GetMovieById(int id) => Seed.Movies.FirstOrDefault(movie => movie.Id == id);
    }
}
