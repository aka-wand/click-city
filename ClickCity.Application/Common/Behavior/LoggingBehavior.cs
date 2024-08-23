using Microsoft.Extensions.Logging;

namespace ClickCity.Application.Common.Behavior
{
    internal class LoggingBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : class
    {
        private readonly ILogger<LoggingBehavior<TRequest, TResponse>> _logger;
        private readonly ScopeCache _scopeCache;

        public LoggingBehavior(ILogger<LoggingBehavior<TRequest, TResponse>> logger, ScopeCache scopeCache)
        {
            _logger=logger;
            _scopeCache=scopeCache;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(next);

            var correlationId = _scopeCache.Get<Guid?>("CorrelationId") ?? Guid.NewGuid();

            var scope = new
            {
                CorrelationId = correlationId,
                RequestName = typeof(TRequest).Name
            };

            using (_logger.BeginScope(scope))
            {
                _logger.LogInformation("Starting request: {Name}", scope.RequestName);

                var response = await next();

                _logger.LogInformation("Request completed successfully: {Name}", scope.RequestName);

                return response;
            }
        }
    }
}