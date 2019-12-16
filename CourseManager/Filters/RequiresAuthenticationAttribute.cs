using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseManager.Filters
{
    public class RequiresAuthenticationAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session != null)
            {
                var users = filterContext.HttpContext.Session["users"]?.ToString();
                if (! string.IsNullOrWhiteSpace(users))
                {
                    return;
                }
                var cookie = filterContext.HttpContext.Response.Cookies?["users"];
                if (! string.IsNullOrEmpty(cookie?.Value))
                {
                    return;
                }
                else
                {
                    throw new UnauthorizedException();
                }
            }
        }
    }
}