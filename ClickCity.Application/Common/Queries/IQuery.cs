namespace ClickCity.Application.Common.Queries
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}