using Microsoft.AspNetCore.Mvc.Abstractions;

namespace rerun
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
