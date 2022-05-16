using CQRSDemo.Application.Interfaces.Commands;

namespace CQRSDemo.Application.Customers.Commands
{
    public class CreateCustomerCommand : ICommand
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
