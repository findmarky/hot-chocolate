using GraphQL.Server.Models;

namespace GraphQL.Server.Subscriptions
{
    public class Subscription
    {
        [Subscribe]
        public Movie MovieAdded([EventMessage] Movie movie) => movie;
    }
}
