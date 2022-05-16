using CQRSDemo.Application.Abstraction;
using CQRSDemo.Application.Interfaces.Commands;
using CQRSDemo.Domain.Entities;
using MediatR;

namespace CQRSDemo.Application.Customers.Commands
{
    public class CustomerCommandHandler : ICommandHandler<CreateCustomerCommand> , ICommandHandler<DeleteCustomerCommand>
    {
        private readonly IWriteDbContext _dbContext;    
        public CustomerCommandHandler(IWriteDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer()
            {
                Name = request.Name,
                LastName = request.LastName,
                BirthDate = request.BirthDate,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
            };

            _dbContext.Customers.Add(customer);
            await _dbContext.SaveChangesAsync();

            return Unit.Value;

            //Create Event e.g CustomerCreated
        }

        public async Task<Unit> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            // Handle Delete
        }
    }
}
