using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Web1
{
    public class MyAuthentication : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization( AuthorizationFilterContext context )
        {
            var user = context.HttpContext.User.Identity;
            
            if ( user == null && !user.IsAuthenticated )
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
