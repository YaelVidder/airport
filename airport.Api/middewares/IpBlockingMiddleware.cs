namespace airport.Api.middewares
{
    public class IpBlockingMiddleware
    {
        private readonly RequestDelegate _next;

        public IpBlockingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("Access denied: Access is not allowed on Saturdays.");
                return;
            }

            await _next(context);
        }

    }
}