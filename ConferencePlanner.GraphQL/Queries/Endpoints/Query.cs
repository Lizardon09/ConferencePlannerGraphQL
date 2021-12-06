using ConferencePlanner.Database;
using ConferencePlanner.Database.Interfaces;
using ConferencePlanner.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencePlanner.GraphQL.Queries
{
    public class Query
    {

        private IDatabaseRepository DatabaseRepository;

        public Query(IDatabaseRepository databaseRepository)
        {
            DatabaseRepository = databaseRepository;
        }

        public IQueryable<Speaker> GetSpeakers() => DatabaseRepository.Get<Speaker>();
        public IQueryable<Earphone> GetEarphones() => DatabaseRepository.Get<Earphone>();
    }
}
