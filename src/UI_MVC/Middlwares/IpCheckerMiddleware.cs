namespace UI_MVC.Middlwares
{
    public class IpCheckerMiddleware
    {
        private readonly RequestDelegate _next;
        
        public IpCheckerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //if (DateTime.Now.Hour >= 10
            //    && DateTime.Now.Hour < 11)
            //    context.Response.WriteAsync("Bad Time");

            //else 
                await _next(context);
        }
    }
}
