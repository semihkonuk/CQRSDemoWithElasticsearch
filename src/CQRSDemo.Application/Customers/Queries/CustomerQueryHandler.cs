using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSDemo.Application.Interfaces.Queries;
using Nest;

namespace CQRSDemo.Application.Customers.Queries
{
    public class CustomerQueryHandler : IQueryHandler<GetCustomersQuery, List<CustomerDto>>
    {
        private readonly IElasticClient _elasticClient;

        public CustomerQueryHandler(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public async Task<List<CustomerDto>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            var searchResponse = await _elasticClient.SearchAsync<CustomerDto>(s => s
                                    .Query(q => q.MatchAll()));

            return searchResponse.Documents.Select(o =>
                new CustomerDto
                {
                    Name = o.Name,
                    LastName = o.LastName,
                })
                .ToList();
        }
    }
}

