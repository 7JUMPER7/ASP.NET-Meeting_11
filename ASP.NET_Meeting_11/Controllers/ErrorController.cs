using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Meeting_11.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            ViewBag.Code = 404;
            return View("ErrorView", (object)"Страница не найдена");
        }

        public ActionResult Forbidden()
        {
            Response.StatusCode = 403;
            ViewBag.Code = 403;
            return View("ErrorView", (object)"Отказано в доступе");
        }
    }
}