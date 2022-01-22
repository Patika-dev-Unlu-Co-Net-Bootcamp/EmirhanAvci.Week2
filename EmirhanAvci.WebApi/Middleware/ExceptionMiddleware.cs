using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace EmirhanAvci.WebApi.Middleware
{
    public class ExceptionMiddleware
    {

        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                await httpContext.Response.WriteAsync(
                    System.Text.Json.JsonSerializer.Serialize(new
                        {
                            StatusCode = httpContext.Response.StatusCode,
                            Message = ex.Message
                        }
                     ));
            }
        }
    }
}
