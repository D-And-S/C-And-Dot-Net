using Microsoft.AspNetCore.Authorization;


// this is for custom authorization
// and we will comlete the requrement that an admin will change other admin role but not own
namespace EmployeeManagement.Security
{
    public class ManageAdminRolesAndClaimsRequirement : IAuthorizationRequirement
    {
        // we implement the IAuthorizationRequirement for custom authoriation
    }
}
