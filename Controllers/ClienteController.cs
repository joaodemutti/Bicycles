using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bicycles.Models;
using Microsoft.AspNetCore.Http;
namespace Bicycles.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public const string SessionKeyLogin = "_login";


        public ClienteController(ILogger<HomeController> logger)
        {
            
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString(SessionKeyLogin)==null)return RedirectToAction("Index","Home",new {area=""});
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}