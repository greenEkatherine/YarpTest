using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore
{
    public class UrlRewriteMiddleware
    {
        private readonly RequestDelegate _next;

        public UrlRewriteMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            if (context.Request.HasFormContentType && context.Request.Form.Count > 0) ;
            
            await _next(context);
        }
    }
}
