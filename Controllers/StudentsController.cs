using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TMADll.Classes;
using TMADll.Models;

namespace TimeManagementApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentClass studentClass = new();
        // Get : Students/Login
        public IActionResult Login()
        {
            // If the student is already loged in sign out
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Exit", "Home");
            }
            return View();
        }

        // Post : Students/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("StudentNumber,Password")] Student student)
        {
            if ((bool)studentClass.LoginUser(student.StudentNumber, student.Password))
            {
                SignIN(student.StudentNumber);
                return RedirectToAction("Index", "StudentModules");
            }

            ModelState.AddModelError("", "Incorrect Login details");
            return View();
        }

        // GET: Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("StudentNumber,FirstName,Surname,Email,PhoneNumber,Password")] Student student)
        {
            if (studentClass.Register(student))
            {
                SignIN(student.StudentNumber);
                return RedirectToAction("Index", "StudentModules");
            }
            ModelState.AddModelError("", "Your Student Number is already registered");
            return View();
        }

        private void SignIN(string StudentNumber)
        {
            // Create a claim for the student number
            List<Claim> claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, StudentNumber)
                    };

            // Create an identity for the student
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            // Create a principal for the student
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            AuthenticationProperties authenticationProperties = new AuthenticationProperties
            {
                IsPersistent = false,
                AllowRefresh = true
            };

            // Sign in the student
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsPrincipal));
        }

    }
}
