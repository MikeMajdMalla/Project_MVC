using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using My_assigment.Models;
using System.Security.Claims;

namespace My_assigment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Login user, string returnUrl = "")
        {

            bool userOk = CheckUser(user);
            if (userOk == true)
            {
                // user log in 
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Name, user.userName));
                await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(identity));
                // checking if the user name and passowrd are correct
                if (returnUrl != "")
                    return Redirect(returnUrl);
                else
                    return RedirectToAction("Loggedin", "loggedin");
            }
            ViewBag.ErrorMessage = "Wrong password";
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        private bool CheckUser(Login userInfo)
        {
            if (userInfo.userName == "mike" && userInfo.password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<IActionResult> SignOutUser()
        {
            await HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
        }



    }


}


