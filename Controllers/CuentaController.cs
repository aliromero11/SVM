using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SVM.Models;

namespace SVM.Controllers
{
    public class CuentaController : Controller
    {
        public IActionResult TraerCuenta()
        {
            return View();
        }
        public IActionResult Registrar()
        {
            return View();
        }
        public IActionResult CerrarSesion()
        {
            return View();
        }
    }
}