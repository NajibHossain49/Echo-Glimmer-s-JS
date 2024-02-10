using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validation.Models;

namespace Validation.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home/Index
        [HttpGet]
        public ActionResult Index()
        {
            return View(new FormData());
        }

        // POST: Home/SubmitForm
        [HttpPost]
        public ActionResult Index(FormData model)
        {
           if (ModelState.IsValid)
            { //will validate the object based on the rules applied in class
                return RedirectToAction("Contact");
            }

            return View(model);
        }

    }
}