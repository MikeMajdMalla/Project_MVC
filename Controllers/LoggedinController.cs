using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace My_assigment.Controllers
{

    // this controller for the logged in page and you have to be logged in to use it
    public class LoggedinController : Controller
    {
        [Authorize]
        public IActionResult loggedin()
        {
            return View();
        }




    }
}
