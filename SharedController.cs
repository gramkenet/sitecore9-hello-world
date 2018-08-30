using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SitecoreTest.Models;

namespace SitecoreTest.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        public ActionResult SharedMVCInnerRendering()
        {
			var model = new SharedViewModel
			{
				Year = Sitecore.DateUtil.ToServerTime(DateTime.UtcNow).Year,
			};

			return View(model);
        }
    }
}