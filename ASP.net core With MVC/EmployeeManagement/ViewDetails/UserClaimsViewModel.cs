using System.Collections.Generic;

namespace EmployeeManagement.ViewDetails
{
    public class UserClaimsViewModel
    {
        public UserClaimsViewModel()
        {
            claims = new List<UserClaim>();
        }
        public string UserId { get; set; }
        public List<UserClaim> claims { get; set; }
    }
}
