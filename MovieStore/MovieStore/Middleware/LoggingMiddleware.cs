namespace MovieStore.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            LogRequest(httpContext);
            await _next(httpContext);
            LogResponse(httpContext);
        }

        private void LogRequest(HttpContext context)
        {
            // Log request details
        }

        private void LogResponse(HttpContext context)
        {
            // Log response details
        }
    }

}
