using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace TestMvc.Constraints
{
    public class LogConstraint : IRouteConstraint
    {

        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            throw new System.NotImplementedException();
        }
    }
}
