using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Web1
{
    public class TestingFilter : ActionFilterAttribute
    {
        public void OnActionExecuting( ActionExecutingContext context )
        {
        }

        public override void OnActionExecuted( ActionExecutedContext context )
        {
        }

        public override void OnResultExecuting( ResultExecutingContext context )
        {
            Console.WriteLine(context.HttpContext.Response.Headers.WWWAuthenticate);
        }

        public override void OnResultExecuted( ResultExecutedContext context )
        {
            Console.WriteLine(context.HttpContext.Response.Headers.WWWAuthenticate);
        }
        
    }
}
