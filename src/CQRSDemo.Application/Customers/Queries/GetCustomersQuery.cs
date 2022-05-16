using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSDemo.Application.Interfaces.Queries;

namespace CQRSDemo.Application.Customers.Queries
{
    public class GetCustomersQuery : IQuery<List<CustomerDto>>
    {

    }
}
