using ConferencePlanner.Database.Models;

namespace ConferencePlanner.Database.Queries
{
    public class Query
    {
        public IQueryable<Speaker> GetSpeakers([Service] ApplicationDBContext context) =>
            context.Speakers;
    }
}
