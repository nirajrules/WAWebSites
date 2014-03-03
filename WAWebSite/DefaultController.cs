using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace WAWebSite
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/
        //public ActionResult Index()
        public string Index()        
        {
            Trace.WriteLine("Executing Index Method");
            return "This is my <b>default</b> action...";
            //return View();
        }
	}
}