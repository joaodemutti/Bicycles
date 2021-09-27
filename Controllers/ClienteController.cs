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
        public static List<ClienteModel> clientes = new List<ClienteModel>{};
         public static ClienteModel ClienteRegistro;

        public ClienteController(ILogger<HomeController> logger)
        {
           _logger = logger;
        }
        
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString(SessionKeyLogin)==null)return RedirectToAction("Index","Home",new {area=""});
            return View();
        }

        public IActionResult Registrar()
        {
            if(HttpContext.Session.GetString(SessionKeyLogin)==null)return RedirectToAction("Index","Home",new {area=""});
            return View();
        }

        public IActionResult Consulta(int cpf)
        {
            ClienteRegistro=new ClienteModel();
            ClienteRegistro.cpf_cli = cpf;
            if(HttpContext.Session.GetString(SessionKeyLogin)==null)return RedirectToAction("Index","Home",new {area=""});
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(ClienteModel cliente)
        {
            if(cliente.cpf_cli==null||cliente.nome_cli==null||cliente.telefone_cli==null||cliente.email_cli==null||cliente.cep_end==null)
            return View(cliente);
            
            clientes.Add(cliente);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}