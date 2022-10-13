namespace WsMiddleware.Middleware
{
    public class LoginChecker
    {
        private readonly RequestDelegate next;
        public LoginChecker(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.StartsWithSegments("/Login/"))
            {
                await next(context);
                return;
            }
            string sessionId = context.Request.Cookies["sessionId"];
            if (sessionId == null)
            {
                // bring user to Login page to get a session
                context.Response.Redirect("/Login/");
            }
            else
            {
                await next(context);
            }
        }
    }

}
