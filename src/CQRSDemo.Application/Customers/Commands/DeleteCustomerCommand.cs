using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSDemo.Application.Interfaces.Commands;

namespace CQRSDemo.Application.Customers.Commands
{
    public class DeleteCustomerCommand : ICommand
    {
        public int CustomerId { get; set; }

    }
}
