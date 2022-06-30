using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace WebAppStandards.Filters
{
    public class AuthenticationFilter : IAsyncActionFilter// ,IAuthorizationFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var authHeader = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault();

            if (!AuthKeys.Keys.Any(x => x.Key == authHeader))
            {
                context.Result = new UnauthorizedObjectResult("Unauthorized User.");
                return;
            }

            var key = AuthKeys.Keys.FirstOrDefault(x => x.Key == authHeader);

            var permissions = AuthKeys.ApiPermissions.FirstOrDefault(x => x.Key == key.Value);

            if (!permissions.Value.Split(",").Any(x => x.ToLower() == context.HttpContext.Request.Path.Value))
            {
                context.Result = new UnauthorizedObjectResult("Unauthorized User.");
                return;
            }

            await next();
        }
    }
}
