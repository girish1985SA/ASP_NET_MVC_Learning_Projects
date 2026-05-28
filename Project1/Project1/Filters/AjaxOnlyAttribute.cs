using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace Project1.Filters
{
    public class AjaxOnlyAttribute : ActionMethodSelectorAttribute
    {
        
        public override bool IsValidForRequest(RouteContext routeContext, ActionDescriptor action)
        {
            if(routeContext.HttpContext.Request.Headers != null && routeContext.HttpContext.Request.Headers.ContainsKey("X-Requested-With") && routeContext.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest"
                )
            {
                return true;
            }
            else
            {
                return false; 
            }
            
            
            //return routeContext.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
        }

    }
}
