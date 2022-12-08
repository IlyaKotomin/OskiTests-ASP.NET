using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OskiTests.Data;
using OskiTests.Data.Static;
using OskiTests.Models;
using System;

namespace OskiTests.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppDatabaseContext _context;

        public AccountController(UserManager<ApplicationUser> userManager,
                                 SignInManager<ApplicationUser> signInManager,
                                 AppDatabaseContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }


        [Authorize(Roles = UserRoles.Admin)]
        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }

        public IActionResult Login() => View(new LoginViewModel());

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewMode)
        {
            if (!ModelState.IsValid) return View(loginViewMode);

            var user = await _userManager.FindByEmailAsync(loginViewMode.EmailAddress);

            if (user == null)
            {
                TempData["Error"] = "User didn't registered yet!";
                return View(loginViewMode);
            }

            var passwordCheck = await _userManager.CheckPasswordAsync(user, loginViewMode.Password);
            var result = await _signInManager.PasswordSignInAsync(user, loginViewMode.Password, false, false);

            if (!passwordCheck || !result.Succeeded)
            {
                TempData["Error"] = "Wrong credentials. Please, try again!";
                return View(loginViewMode);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register() => View(new RegisterViewModel());

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid) return View(registerViewModel);

            var user = await _userManager.FindByEmailAsync(registerViewModel.EmailAddress);
            if (user != null)
            {
                TempData["Error"] = "This email address is already in use";
                return View(registerViewModel);
            }

            var newUser = new ApplicationUser()
            {
                FullName = registerViewModel.FullName,
                Email = registerViewModel.EmailAddress,
                UserName = registerViewModel.EmailAddress
            };
            var newUserResponse = await _userManager.CreateAsync(newUser, registerViewModel.Password);

            if (!newUserResponse.Succeeded)
            {
                string errorsText = "\n";

                foreach (var error in newUserResponse.Errors)
                    errorsText += $"{error.Description}\n";

                TempData["Error"] = errorsText;
                return View(registerViewModel);
            }

            await _userManager.AddToRoleAsync(newUser, UserRoles.User);
            return View("RegisterCompleted");
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync();
            return View();
        }

        public IActionResult AccessDenied(string returnUrl)
        {
            return View();
        }
    }
}
