using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserTask.Library.DataController.Role;
using UserTask.Library.DataController.User;
using UserTask.Library.DataController.UserRole;
using UserTask.Library.Entity.ViewModel;
using UserTask.Library.Helper;

namespace UserTask.Controllers
{
    
    public class AccountController : Controller
    {
        readonly Dgetrole _dgetrole = new Dgetrole();
        readonly DGetByEmail _dgetbyemail = new DGetByEmail();
        readonly Dgetuserrole _dgetuserrole = new Dgetuserrole();

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {

            LoginViewModel model = new LoginViewModel
            {
                ReturnUrl = returnUrl,
                // ExternalLogins =
                //(await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (model != null)
            {
                var user = await _dgetbyemail.UserByEmail(model.Email);
                if (user.Id == 0)
                {
                    return View("Login");
                }
                PasswordHasher pass = new PasswordHasher();
                var result = pass.Verify(model.Password, user.Password);
                if (result)
                {
                    var role = await _dgetuserrole.UserroleByuserId(user.Id);

                    var Rolname = await _dgetrole.RoleById(role.RoleId);
                    var claims = new List<Claim>
                        {
                          new Claim(ClaimTypes.Name, model.Email),
                          //new Claim("FullName", user.FullName),
                          new Claim(ClaimTypes.Role,Rolname.Rolename)

                         };
                    var claimsIdentity = new ClaimsIdentity(

                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        AllowRefresh = true,
                        //// Refreshing the authentication session should be allowed.

                        ExpiresUtc = DateTimeOffset.UtcNow.AddDays(7),
                        //// The time at which the authentication ticket expires. A 
                        //// value set here overrides the ExpireTimeSpan option of 
                        //// CookieAuthenticationOptions set with AddCookie.

                        IsPersistent = true,
                        //// Whether the authentication session is persisted across 
                        //// multiple requests. When used with cookies, controls
                        //// whether the cookie's lifetime is absolute (matching the
                        //// lifetime of the authentication ticket) or session-based.

                        IssuedUtc = DateTime.Now,
                        //// The time at which the authentication ticket was issued.

                        RedirectUri = new PathString("/Accounts/Login/")
                        // The full path or absolute URI to be used as an http 
                        // redirect response value.

                    };

                    var claimprincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(
                         "CookieAuthenticationDefaults.AuthenticationScheme", claimprincipal, authProperties);
                    return RedirectToAction("WorkingList", "Board");

                }
            }
            return View("Login");
        }



        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("CookieAuthenticationDefaults.AuthenticationScheme");
            return Redirect("/Account/Login");
        }


    }
}