using System.Collections.Generic;
using System.Security.Claims;

namespace EmployeeManagement.Models
{
    public static class ClaimsStore
    {
        public static List<Claim> AllClaim = new List<Claim>()
        {
            // claim class has multiple overload construcotr 
            // we used second which take claim type and claim value 
            new Claim("Create Role", "Create Role"),
            new Claim("Edit Role", "Edit Role"),
            new Claim("Delete Role", "Delete Role"),
        };


    }
}
