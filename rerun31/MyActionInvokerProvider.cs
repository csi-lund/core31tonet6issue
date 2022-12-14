using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Abstractions;
using System;

namespace rerun31
{
    internal class MyActionInvokerProvider : IActionInvokerProvider
    {
        public void OnProvidersExecuting(ActionInvokerProviderContext context)
        {
            Console.WriteLine(context.ActionContext.HttpContext.Request.Path);
            context.ActionContext.RouteData.DataTokens.Add("Test", "MyValue");
        }

        public void OnProvidersExecuted(ActionInvokerProviderContext context)
        {

        }

        public int Order => int.MaxValue;
    }
}
