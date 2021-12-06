using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencePlanner.GraphQL.Queries.Models
{
    public class TPayload<T> 
    {
        public T Payload { get; }
        public TPayload(T payload)
        {
            Payload = payload;
        }
    }
}
