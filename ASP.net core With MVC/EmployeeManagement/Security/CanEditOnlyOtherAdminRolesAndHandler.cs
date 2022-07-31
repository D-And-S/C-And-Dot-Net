using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

// this is for custom claim authorization
// and we will comlete the requrement that an admin will change other admin role but not own
namespace EmployeeManagement.Security
{
    public class CanEditOnlyOtherAdminRolesAndHandler : AuthorizationHandler<ManageAdminRolesAndClaimsRequirement>
    {
        // since we implement the IAuthorizationRequirement interface so we need
        // to create custom Handler AuthorizationHandler<T>
        // now authorization has virtual method which we need to override

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ManageAdminRolesAndClaimsRequirement requirement)
        {
            // niche amra authorizationFilterContext use korechi object hisebe 
            // Resource property ke karon ata amra Adiministrator controller 
            // ar multiple method e use korbo 
            var authFilterContext = context.Resource as AuthorizationFilterContext;

            if (authFilterContext != null)
            {
                return Task.CompletedTask;

            }

            // amader context ache.. now ai context ar moddhe User property ache 
            // user property theke amra list of user claim access korte parbo
            // to get the id of the logged in user amra ClaimTypes ar NameIdentifier Method
            // use korbo

            // je loggedIn ache tar ID
            var loggedInAdminId = context.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;

            //user Id urle theke nea
            string adminIdBeingEdited = authFilterContext.HttpContext.Request.Query["Id"];

            //now amra role and claim type check korbo

            if (context.User.IsInRole("Admin") &&
                context.User.HasClaim(claim => claim.Type == "Edit ROle") &&
                adminIdBeingEdited.ToLower() != loggedInAdminId.ToLower())
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;

        }
    }
}
