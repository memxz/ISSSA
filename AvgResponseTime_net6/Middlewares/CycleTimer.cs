using System;
using Microsoft.AspNetCore.Mvc;
using AvgResponseTime_net6.Models;

namespace AvgResponseTime_net6.Middlewares;

public class CycleTimer
{
    private readonly RequestDelegate next;
    private ResponseTracker tracker;
    
    public CycleTimer(RequestDelegate next, ResponseTracker tracker)
    {
        this.next = next;
        this.tracker = tracker;
    }

    public async Task Invoke(HttpContext context)
    {
        long startTime = 0;

        string path = context.Request.Path.ToString();

        if (path.Contains("Read") || path.Contains("Write")) {
            // capture start time   
            startTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }

        await next(context);

        if (path.Contains("Read") || path.Contains("Write"))
        {
            // capture end time
            long endTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            // compute difference
            double duration = ((double) (endTime - startTime)) / 1000;                

            tracker.StoreDuration(path, duration);
        }
    }
}


