using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WAWebSite
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/
        //public ActionResult Index()
        public string Index()
        {
            return "This is my <b>default</b> action...";
            //return View();
        }
	}
}