using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SVM.Models;

namespace SVM.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult RegistroPedido()
        {
            return View();
        }
        public IActionResult ConfirmaPedido()
        {
            return View();
        }

}
}