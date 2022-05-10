using Calculadora_de_Buteco.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Calculadora_de_Buteco.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}