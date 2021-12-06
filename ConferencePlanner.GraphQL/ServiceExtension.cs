using ConferencePlanner.Database.Interfaces;
using ConferencePlanner.Database.Models;
using ConferencePlanner.Database.Queries;
using ConferencePlanner.GraphQL.Queries;
using ConferencePlanner.GraphQL.Queries.Endpoints;
using ConferencePlanner.GraphQL.Queries.Mutations;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencePlanner.GraphQL
{
    public static class GraphQLServiceExtension
    {
        public static void ConfigureGraphQLService(this IServiceCollection service)
        {
            service
                .AddTransient<IDatabaseRepository, DatabaseRepository>()        //Transient for Dbcontext implimentation of EF Core
                .AddGraphQLServer()
                .AddQueryType<Query>()                                          //Register all Query and Mutation Enpoints
                .AddMutationType<EarphoneMutation>()
                .AddMutationType<SpeakerMutation>();
        }

        public static void ConfigureGraphQLBuild(this WebApplication app)
        {
            app.UseGraphQLPlayground();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
