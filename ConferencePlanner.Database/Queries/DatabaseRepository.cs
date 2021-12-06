using ConferencePlanner.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencePlanner.Database.Queries
{
    public class DatabaseRepository : IDatabaseRepository
    {
        private ApplicationDBContext Context;

        public DatabaseRepository(ApplicationDBContext context)
        {
            Context = context;
        }

        public async Task<int> AddAsync<T>(T entry) where T : class
        {
            Context.Set<T>().Add(entry);

            return await Context.SaveChangesAsync();
        }

        public IQueryable<T> Get<T>() where T : class
        {
            return Context.Set<T>();
        }
    }
}
