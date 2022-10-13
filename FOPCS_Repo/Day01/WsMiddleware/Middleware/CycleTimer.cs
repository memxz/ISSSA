namespace WsMiddleware.Middleware
{
    public class CycleTimer
{
 private readonly RequestDelegate next;
 public CycleTimer(RequestDelegate next)
 {
 this.next = next;
 }
 public async Task Invoke(HttpContext context)
 {
 // capture start time
 long startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
 await next(context);
 // capture end time
 long endTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
 // compute difference
 int duration = (int) (endTime - startTime);
 }
}

}
