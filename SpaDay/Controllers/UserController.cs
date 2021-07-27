using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }




        // [HttpPost("/User/Add")]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost("/User/Add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                ViewBag.username = newUser.Name;
                return View("~/Views/User/Index.cshtml");
            }


            else

            {

                ViewBag.error = "Passwords do not match";

                return View("~/Views/User/Add.cshtml");
            }



        }



    }
}