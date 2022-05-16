using MediatR;

namespace CQRSDemo.Application.Interfaces.Queries
{
    public interface IQuery<TResult> : IRequest<TResult>
    {

    }
}
