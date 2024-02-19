using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using My_assigment.Models;
namespace My_assigment.Controllers
{
    public class LogginController : Controller
    {
         // this controller made for log in 
            public ActionResult admin()
            {
                return View();
            }
            [HttpPost]
            public async Task<IActionResult> Index(Login user, string returnUrl = "")
            {
                
                bool userOk = CheckUser(user);
                if (userOk == true)
                {
                    // Allt stämmer, logga in användaren
                    var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                    identity.AddClaim(new Claim(ClaimTypes.Name, user.userName));
                    await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(identity));
                    
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



        }
    }

