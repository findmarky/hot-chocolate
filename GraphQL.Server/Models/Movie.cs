namespace GraphQL.Server.Models
{
    public record Movie(int Id, string Title, List<Actor> Actors);
}
