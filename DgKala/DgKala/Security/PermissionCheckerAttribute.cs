using DgKala.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DgKala.Security
{
    public class PermissionCheckerAttribute:AuthorizeAttribute,IAuthorizationFilter
    {
        private IPermissionServices _permissionServices;
        private int _permissionId = 0;
        public PermissionCheckerAttribute(int permissionId)
        {
            _permissionId = permissionId;
        }
        public PermissionCheckerAttribute(IPermissionServices permissionServices)
        {
            _permissionServices = permissionServices;
            
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _permissionServices =
                (IPermissionServices) context.HttpContext.RequestServices.GetService(typeof(IPermissionServices));
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                string userName = context.HttpContext.User.Identity.Name;

                if (!_permissionServices.CheckerPermission(_permissionId, userName))
                {
                    context.Result = new RedirectResult("/Login");
                }

            }
            else
            {
                context.Result = new RedirectResult("/Login");
            }
        }
    }
}
