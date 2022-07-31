using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class EditRoleViewModel
    {
        // we initialize user with empty list otherwise.. if the particular role does not
        // contain any user then it will provide error. 
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
        public string Id { get; set; }

        [Required(ErrorMessage = "Role Name is Required")]
        public string RoleName { get; set; }

        // akta role ar against e onek users thakte pare ajonno amra list of users niyeche
        public List<string> Users { get; set; }

    }
}
