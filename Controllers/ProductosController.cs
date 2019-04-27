using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SVM.Models;

namespace SVM.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult RopaPro()
        {
            return View();
        }
        public IActionResult ZapatosPro()
        {
            return View();
        }
        public IActionResult BellezaPro()
        {
            return View();
        }

}}