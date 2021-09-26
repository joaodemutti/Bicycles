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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public const string SessionKeyLogin = "_login";


        public HomeController(ILogger<HomeController> logger)
        {
            
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }
        
        public IActionResult Index()
        {
            
            if(HttpContext.Session.GetString(SessionKeyLogin)!=null)
            {
            return View();
            }
            else return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult Login(FuncionarioModel fun)
        {
            ViewBag.Login = fun.login_fun;
            HttpContext.Session.SetString(SessionKeyLogin,fun.login_fun);
            if(HttpContext.Session.GetString(SessionKeyLogin)!=null)
            return RedirectToAction("Index");
            else return View(fun);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
