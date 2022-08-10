using GraphQL.Server.Data;
using GraphQL.Server.Models;
using GraphQL.Server.Subscriptions;
using HotChocolate.Subscriptions;

namespace GraphQL.Server.Mutations
{
    public class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
        {
            descriptor.Field(mutation => mutation.AddMovie(default, default, default));
        }
    }

    public class Mutation
    {
        public async Task<Movie> AddMovie(string movieName, List<Actor> actors, [Service] ITopicEventSender sender)
        {
            var id = Seed.Movies.Max(a => a.Id) + 1;

            var movie = new Movie(id, movieName, actors);

            Seed.Movies.Add(movie);

            await sender.SendAsync(nameof(Subscription.MovieAdded), movie);

            return movie;
        }
    }
}
