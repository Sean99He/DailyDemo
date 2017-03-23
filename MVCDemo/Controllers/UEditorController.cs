using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class UEditorController : Controller
    {
        // GET: UEditor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            return View();
        }
    }
}