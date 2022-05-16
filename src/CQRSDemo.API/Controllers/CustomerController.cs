using CQRSDemo.Application.Customers.Commands;
using CQRSDemo.Application.Customers.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSDemo.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetCustomersQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteCustomerCommand { CustomerId = id }));
        }
    }
}
