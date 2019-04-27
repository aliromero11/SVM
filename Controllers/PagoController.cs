using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SVM.Models;

namespace SVM.Controllers
{
    public class PagoController : Controller
    {
        public IActionResult RealizarPedido()
        {
            return View();
        }
        public IActionResult ConfirmaPago()
        {
            return View();
        }

  }}