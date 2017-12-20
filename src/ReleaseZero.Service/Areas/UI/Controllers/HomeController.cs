using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReleaseZero.Service.Areas.UI.Models;
using Serilog;

namespace ReleaseZero.Service.Areas.UI.Controllers
{
    /// <summary>
    /// A controller intercepts the incoming browser request and returns
    /// an HTML view (.cshtml file) or any other type of data.
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Area("UI")]
    public class HomeController : Controller
    {
        /// <summary>
        /// Index action in Home controller
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 3600)]
        [Route("/")]
        [Route("/Home")]
        [Route("/Home/Index")]
        public IActionResult Index()
        {
            Log.Debug("Request to Index action in HomeController");
            // The view being returned is calculated based on the name of the
            // controller (Home) and the name of the action method (Index).
            // So in this case, the view returned is /Views/Home/Index.cshtml.
            return View();
        }

        /// <summary>
        /// About action in Home controller
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 3600)]
        [Route("/Home/About")]
        public IActionResult About()
        {
            // Creates a model and passes it on to the view.
            Employee[] model =
            {
                new Employee { Name = "Alfred", Title = "Manager" },
                new Employee { Name = "Sarah", Title = "Accountant" }
            };

            return View(model);
        }
    }
}
