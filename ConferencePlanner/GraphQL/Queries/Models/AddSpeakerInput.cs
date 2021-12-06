namespace ConferencePlanner.GraphQL.Queries.Mutations
{
    public record AddSpeakerInput(
        string Name,
        string Bio,
        string Website
    );
}
