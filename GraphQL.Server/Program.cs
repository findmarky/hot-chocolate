using GraphQL.Server.Mutations;
using GraphQL.Server.Resolvers;
using GraphQL.Server.Subscriptions;

var builder = WebApplication.CreateBuilder(args);

// GraphQL configuration.
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddSubscriptionType<Subscription>()
    .AddInMemorySubscriptions();

var app = builder.Build();

// Required for subscriptions.
app.UseWebSockets();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.Run();