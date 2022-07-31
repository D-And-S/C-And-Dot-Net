using EmployeeManagement.Models;
using EmployeeManagement.ViewDetails;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    /*
        * amra akhane kichu method allowannymouse korechi 
        * jehetu amra autohrization startup file e configure korechi
        * ajojnno akhane login and register page allowannymouse korechi
        * ta nah korle url error dekhabe 
     */
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        // we use built it usermanger for create user
        // and signInManager for sign in
        public AccountController(UserManager<ApplicationUser> userManager,
                                 SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            //Register User through UserManager and SigninManager
            if (ModelState.IsValid)
            {
                // we used applicationUser which inherit IdentityUser
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    City = model.City,
                };



                // we will use CreateAsynch Method to create user
                // it will also hash the model password
                var result = await _userManager.CreateAsync(user, model.Password);

                //check user is created successfully
                // if it is created successfully we will use signInAsync
                if (result.Succeeded)
                {
                    if (_signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                    {
                        return RedirectToAction("UserList", "Administrator");
                    }

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    //after sign in we will redirect to index section
                    return RedirectToAction("Index", "Home");
                }

                // if the user does not create successfully then we will display error
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                //check username password, and will it be persistance
                var signIn = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                // if log in success
                if (signIn.Succeeded)
                {
                    /*
                      return url means jokhon ami kono link e click korbo
                      kintu amake authorization korte hobe mane login korte hobe
                      then log in korle sora sori sei linke chole jabe
                     */

                    //we use local url for preventing attacker to attack through URL
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }                    
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            //if the login not valid we re render the login view
            return View(model);
        }

        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                // why we JSon because asp.net core mvc and jquery validate together use 
                // ajax internally 
                return Json(true);
            }
            else
            {
                return Json($"Email {email} is already in use");
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
