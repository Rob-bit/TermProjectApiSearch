﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ProfileSearchAPIProject.FilterSecurity
{
    public class ApiKeyAuthorization : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //if(!context.HttpContext.Request.Headers.TryGetValue(ApiKeyHeaderName, out var potentialApiKey)){
            //    context.Result = new UnauthorizedResult();
            //    return;
            //}

            //var configuration = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
            //var apiKey = configuration.GetValue<string>(Key: "ApiKey");

            //if (!apiKey.Equals(potentialApiKey))
            //{
            //    context.Result = new Una
            //}

            //await next();
        }
    }

}
