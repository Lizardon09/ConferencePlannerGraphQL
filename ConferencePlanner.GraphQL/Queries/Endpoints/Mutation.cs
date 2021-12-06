using ConferencePlanner.Database;
using ConferencePlanner.Database.Interfaces;
using ConferencePlanner.GraphQL.Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencePlanner.GraphQL.Queries.Mutations
{
    public class Mutation<T> where T : class
    {
        private IDatabaseRepository DatabaseRepository;

        public Mutation(IDatabaseRepository databaseRepository)
        {
            DatabaseRepository = databaseRepository;
        }

        public async Task<TPayload<T>> AddAsync(
            T input,
            [Service] ApplicationDBContext context)
        {

            var temp = await DatabaseRepository.AddAsync(input);

            return new TPayload<T>(input);
;       }

        /*
         *  ToAdd:
         * 
         *  - AddBulkAysnc
         *  - UpdateAsync
         *  - UpdateBulkAsync
         *  - DeleteAsync
         *  - DeleteBulkAsync
         * 
         */

    }
}
