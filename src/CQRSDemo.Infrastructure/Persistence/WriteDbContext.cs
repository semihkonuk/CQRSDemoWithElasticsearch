using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSDemo.Application.Abstraction;
using CQRSDemo.Domain.Entities;
using CQRSDemo.Infrastructure.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CQRSDemo.Infrastructure.Persistence
{
    public class WriteDbContext : DbContext, IWriteDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public WriteDbContext(DbContextOptions options) 
            : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        }
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
