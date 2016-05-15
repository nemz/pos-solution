using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;

namespace ModernPOS.WebAPI.Controllers
{
    /// <summary>
    /// API Docs Controller
    /// </summary>
    public class DocsController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.Title = "Modern POS API Docs";
            var apiExplorer = GlobalConfiguration.Configuration.Services.GetApiExplorer();
            
            return View(apiExplorer);
        }
    }
}
