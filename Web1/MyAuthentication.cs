using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Web1
{
    public class MyAuthentication : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization( AuthorizationFilterContext context )
        {   
        }
    }
}
