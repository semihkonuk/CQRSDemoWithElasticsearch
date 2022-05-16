using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSDemo.Application.Abstraction
{
    public interface IWriteDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        Task<int> SaveChangesAsync();
    }
}
