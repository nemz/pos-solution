using ModernPOS.Core;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ModernPOS.Business.Services;namespace ModernPOS.Presentation.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
            IKernel _kernel = new StandardKernel();
            INinjectModule module = new FactoryModule();
            _kernel.Load(module);
            IServiceFactoryNinject _factory = _kernel.Get<IServiceFactoryNinject>();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
