using GraphQL.Server.Models;

namespace GraphQL.Server.Data
{
    public static class Seed
    {
        public static List<Movie> Movies = SeedData();

        private static List<Movie> SeedData()
        {
            var theDarkKnightActors = new List<Actor>
            {
                new("Christian", "Bale"),
                new("Heath", "Ledger"),
                new("Michael", "Caine")
            };

            var inceptionActors = new List<Actor>
            {
                new("Leonardo", "DiCaprio"),
                new("Joseph", "Gordon-Levitt")
            };

            var theShawshankRedemptionActors = new List<Actor>()
            {
                new("Tim", "Robbins"),
                new("Morgan", "Freeman"),
                new("Bob", "Gunton"),
                new("William", "Sadler")
            };

            var movies = new List<Movie>
            {
                new(1,"The Dark Knight", theDarkKnightActors),
                new(2, "Inception", inceptionActors),
                new(3, "The Shawshank Redemption", theShawshankRedemptionActors)
            };

            return movies;
        }
    }
}
