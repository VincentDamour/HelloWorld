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
        public ActionResult PageValidation(ContactModels Model)
        {
            ViewBag.Message = "Voici l'exercise de validation.";
            if (ModelState.IsValid)
            {
                return RedirectToAction("Home/Index");
            }
            return View();
        }

    }
}
