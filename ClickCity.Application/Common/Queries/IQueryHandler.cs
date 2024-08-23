using ClickCity.Application.Common.Commands;

namespace ClickCity.Application.Common.Queries
{
    public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse> where TQuery : IQuery<TResponse>
    {
    }
}