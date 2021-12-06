using ConferencePlanner.Database.Interfaces;
using ConferencePlanner.Database.Models;
using ConferencePlanner.GraphQL.Queries.Mutations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencePlanner.GraphQL.Queries.Endpoints
{
    public class SpeakerMutation : Mutation<Speaker>
    {
        public SpeakerMutation(IDatabaseRepository databaseRepository) : base(databaseRepository)
        {
        }
    }

    public class EarphoneMutation : Mutation<Earphone>
    {
        public EarphoneMutation(IDatabaseRepository databaseRepository) : base(databaseRepository)
        {
        }
    }
}
