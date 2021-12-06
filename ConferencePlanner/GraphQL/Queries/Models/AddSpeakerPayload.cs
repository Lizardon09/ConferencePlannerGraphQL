using ConferencePlanner.Database.Models;

namespace ConferencePlanner.GraphQL.Queries.Mutations
{
    public class AddSpeakerPayload
    {
        public AddSpeakerPayload(Speaker speaker)
        {
            Speaker = speaker;
        }

        public Speaker Speaker { get; }
    }
}
