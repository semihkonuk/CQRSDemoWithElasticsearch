using MediatR;

namespace CQRSDemo.Application.Interfaces.Commands
{
    public interface ICommand : IRequest
    {
    }

    public interface ICommand<TResult> : IRequest<TResult>
    {
    }
}
