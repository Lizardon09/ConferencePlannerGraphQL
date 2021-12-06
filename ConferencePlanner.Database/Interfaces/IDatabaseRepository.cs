using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencePlanner.Database.Interfaces
{
    public interface IDatabaseRepository
    {
        IQueryable<T> Get<T>() where T : class;
        Task<int> AddAsync<T>(T entry) where T : class;
    }
}
