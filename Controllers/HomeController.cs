using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SVM.Models;
using Microsoft.AspNetCore.Authorization;


namespace SVM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          @ViewData["Title"]="ALJHON, pedido online";
          return View();
        }
        public IActionResult Ubicacion()
        {
          @ViewData["Title"]="Ubicanos";
          return View();
        }
        public IActionResult Somos()
        {
          @ViewData["Title"]="Somos";
          return View();
        }
        public IActionResult Contacto()
        {
          @ViewData["Title"]="Contactanos";
          return View();
        }
        [Authorize]
         public IActionResult CarritoPedido()
        {
          @ViewData["Title"]="Carro de Pedido";
          return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
