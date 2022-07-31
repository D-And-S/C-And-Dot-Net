using EmployeeManagement.Models;
using EmployeeManagement.ViewDetails;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    // we will do role based authorization
    [Authorize(Roles = "Admin,Super Admin")]

    // if we use variation like this then the user must be Admin and Super Admin
    /*[Authorize(Roles = "Admin")]
    [Authorize(Roles = "Super Admin")]*/

    public class AdministratorController : Controller
    {
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<ApplicationUser> _userManager;

        // we need user which they belongs to role that's why 
        // we need to injected UserManager to fetch the user
        public AdministratorController(RoleManager<IdentityRole> roleManager,
                                       UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> UserList()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(users);
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            var users = await _userManager.FindByIdAsync(id);
            if (users == null)
            {
                ViewBag.ErrorMessage = $"User with Id= {id} cannot be found";
                return View("NotFound");
            }

            //Fetch all the claim of the user
            var userClaim = await _userManager.GetClaimsAsync(users);

            //Fetch all the role 
            var userRoles = await _userManager.GetRolesAsync(users);

            var model = new EditUserViewModel
            {
                Id = users.Id,
                Email = users.Email,
                UserName = users.UserName,
                City = users.City,

                //select claims
                Claims = userClaim.Select(clm => clm.Value).ToList(),
                Roles = userRoles
            };

            return View(model);

        }


        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                user.Email = model.Email;
                user.UserName = model.UserName;
                user.City = model.City;

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("UserList");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }


            else
            {
                var result = await _userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListUsers");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("UserList");
            }

        }

        [HttpGet]
        [Authorize(Policy = "EditRolePolicy")]
        public async Task<IActionResult> ManageUserRole(string userId)
        {
            ViewBag.userId = userId;

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }

            var model = new List<UserRolesViewModel>();

            foreach (var role in _roleManager.Roles.ToList())
            {
                var userRoloViewModel = new UserRolesViewModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name,
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoloViewModel.IsSelected = true;
                }
                else
                {
                    userRoloViewModel.IsSelected = false;
                }

                model.Add(userRoloViewModel);
            }

            var data = View(model);

            return data;
        }
        
        [HttpPost]
        [Authorize(Policy = "EditRolePolicy")]
        public async Task<IActionResult> ManageUserRole(List<UserRolesViewModel> model, string userId)
        {

            var user = await _userManager.FindByIdAsync(userId);



            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }

            // retrieve all rolse of that user
            var roles = await _userManager.GetRolesAsync(user);

            //remove all existing user role
            var result = await _userManager.RemoveFromRolesAsync(user, roles);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing roles");
                return View(model);
            }

            // je role guli select korbe setar jonno 
            var selectedRole = model.Where(x => x.IsSelected).Select(y => y.RoleName);
            result = await _userManager.AddToRolesAsync(user, selectedRole);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected rolse to user");
                return View(model);
            }

            return RedirectToAction("EditUser", new { Id = userId });

        }


        [HttpPost]
        //claim based Authorizaation
        [Authorize(Policy = "DeleteRolePolicy")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                return View("NotFound");
            }

            else
            {
                try
                {
                    var result = await _roleManager.DeleteAsync(role);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("ListRoles");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View("ListRoles");
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorTitle = $"{role.Name} role is in use";
                    ViewBag.ErrorMessage = $"{role.Name} role cannot be deleted as there are users " +
                        $"in the role. If you wan to delete this role, Please remove the users from " +
                        $"the role and then try to delete";
                    return View("Error");
                }
            }

        }

        [HttpGet]
        //[AllowAnonymous]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                var identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };

                var result = await _roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Administrator");
                }

                // this result object has error property we will loop error property
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }

            // we pass the model here because if the validation is not successful then 
            // we pass the model validation to the view
            return View(model);

        }

        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        [Authorize(Policy ="EditRolePolicy")]
        // we use this method to featch the role along with it's users
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                return View("NotFound");
            }

            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name,
            };

            // akhane _userManager.Users hocche IQuerable jeta server theke data 
            // filter kore 
            var userList = await _userManager.Users.ToListAsync();

            foreach (var user in userList)
            {
                //now amra check korbo particular user ar kono role ache ki na
                var checkUserRole = await _userManager.IsInRoleAsync(user, role.Name);

                // jodi role thake tahole amra EditRoleViewModel e users property te
                // user add korbo
                if (checkUserRole)
                {
                    model.Users.Add(user.UserName);
                }
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Policy = "EditRolePolicy")]
        // we use this method edit the role data
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            // check the role by it's id which come from EditRole.CHTML through model
            var role = await _roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                //if found the role we will update the role name value
                role.Name = model.RoleName;

                // use updateAsynch to update the roll
                var result = await _roleManager.UpdateAsync(role);

                // if it is successfully updated the we redirect to Listrole View 
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            // get roleid from view (asp-route-roleId)
            ViewBag.roleId = roleId;

            //find role
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.errorMessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }

            var model = new List<UserRoleViewModel>();

            // get all the user
            var userList = await _userManager.Users.ToListAsync();

            // add all the user to UserROleViewModel List
            foreach (var user in userList)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                // it is checking if the particular user is a member of that role

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }

                // we add the model object to the model. tar mane model ar joto value 
                // ache segula amra oi model e add korbo
                model.Add(userRoleViewModel);
            };

            // jehetu value guli model e add korechi akhon model return korbo
            return View(model);

        }

        // apply role for user into mapping table
        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }

            // loop throug the model
            for (int i = 0; i < model.Count; i++)
            {
                // we will find user by user ID
                var user = await _userManager.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;

                // now we will check if the user is selected for particular role and that 
                // user is not mapping yet for this role then amra sei user ke particular 
                // role e add korbo

                if (model[i].IsSelected && !(await _userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                // jodi user nah select thake 
                // abong se user jodi alreay se role ar under e hoy tahole
                else if (!model[i].IsSelected && (await _userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    // akhane amra duita case solve korar jonno continue use korecchi
                    // if the user is selected and if it is already in the role then we will do nothing
                    // if the user is not selected and not in the role then we will do nothing
                    continue;
                }

                if (result.Succeeded)
                {
                    // this expression measn we have more user role
                    // ajonno amra process abar notun kore suru korechi
                    if (i < (model.Count - 1))
                        continue;
                    else
                        // we reach end of the loop and send back to the user to Edit role by passing roleId
                        return RedirectToAction("EditRole", new { Id = roleId });
                }
            }
            return RedirectToAction("EditRole", new { Id = roleId });

        }

        // this method is for manage user claims
        [HttpGet]
        public async Task<IActionResult> ManageClaims(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }

            // fetch all the claims
            var existingUserClaims = await _userManager.GetClaimsAsync(user);

            var model = new UserClaimsViewModel
            {
                UserId = user.Id
            };

            foreach (Claim claim in ClaimsStore.AllClaim)
            {
                var userClaim = new UserClaim
                {
                    ClaimType = claim.Type
                };

                // if the user has the claim, set IsSelected property to true, 
                // so the checkbox will be checked
                if (existingUserClaims.Any(c => c.Type == claim.Type))
                {
                    userClaim.IsSelected = true;
                }

                model.claims.Add(userClaim);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ManageClaims(UserClaimsViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {model.UserId} cannot be found";
                return View("NotFound");
            }

            var claims = await _userManager.GetClaimsAsync(user);
            // removeClaimsAsynch method  check weather user has claim or not
            var result = await _userManager.RemoveClaimsAsync(user, claims);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing claims");
                return View(model);
            }

            //get selected claims
            var selectedClaim = model.claims.Where(c => c.IsSelected).Select(d=> new Claim(d.ClaimType, d.ClaimType));

            result = await _userManager.AddClaimsAsync(user, selectedClaim);

            return RedirectToAction("EditUser", new {Id = model.UserId});
        }
    }
}
