using ConferencePlanner.Database.Queries;
using ConferencePlanner.GraphQL.Queries.Mutations;

namespace ConferencePlanner.GraphQL
{
    public static class GraphQLServiceExtension
    {
        public static void ConfigureGraphQLService(this IServiceCollection service)
        {
            service
                .AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>();
        }
    }
}
