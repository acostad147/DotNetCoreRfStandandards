using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppStandards.Filters
{
    public class AuthorizationFilter : IAsyncActionFilter
    {
        private readonly ILogger<AuthorizationFilter> _logger;
        private readonly string[] _permissions;

        public AuthorizationFilter(ILogger<AuthorizationFilter> logger, string[] permissions)
        {
            _logger = logger;
            _permissions = permissions;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            return;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            
        }

        public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            

            return next();
        }
    }
}
