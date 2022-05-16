using MediatR;

namespace CQRSDemo.Application.Interfaces.Queries
{
    public interface IQueryHandler<TQuery, TResult> :
       IRequestHandler<TQuery, TResult> where TQuery : IQuery<TResult>
    {

    }
}
