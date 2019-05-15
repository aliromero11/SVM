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
        public IActionResult Listar()
        {
            return View();
        }
        public IActionResult Filtrar()
        {
            return View();
        }
         public IActionResult Buscar()
       {
           return View();
       }
       // va al carrito y del carrito al pago(hellen)
       public IActionResult Comprar()
       {
           return View();
       }

        public IActionResult AgregarCarrito()
        {
            return View();
        }

}}