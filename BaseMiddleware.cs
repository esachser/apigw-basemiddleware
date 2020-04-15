using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BaseMiddleware
{
    public delegate Task MiddlewareDelegate(HttpContext context, MiddlewareDelegate next);

    public interface IBaseMiddleware
    {
        Task Invoke(HttpContext context, MiddlewareDelegate next);
    }
}
