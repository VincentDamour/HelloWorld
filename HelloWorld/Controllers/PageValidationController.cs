using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class PageValidationController : Controller
    {
        //
        // GET: /PageValidation/

        public ActionResult PageValidation()
        {
            ViewBag.Message = "Voici l'exercise de validation.";
            return View();
        }

        [HttpPost]
        public ActionResult PageValidation(PageValidationModels Model)
        {
            ViewBag.Message = "Voici l'exercise de validation.";
            if (ModelState.IsValid)
            {
                HomeController HCRedirec = new HomeController();
                return RedirectToAction("Index","Home");
            }
            return View();
        }

    }
}
