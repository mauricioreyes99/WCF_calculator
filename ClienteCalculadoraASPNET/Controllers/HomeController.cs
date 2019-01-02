using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClienteCalculadoraASPNET.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string num1, string num2, string Operaciones, string Operacion)
        {
            var Numero1 = double.Parse(num1);
            var Numero2 = double.Parse(num2);
            using (Calculator.CalculatorWCFClient WS = new Calculator.CalculatorWCFClient())
            {
                if(Operaciones == "Suma")
                {
                    ViewBag.resultado = "El resultado es " + WS.Suma(Numero1, Numero2);
                }else if (Operaciones == "Resta")
                {
                    ViewBag.resultado = "El resultado es " + WS.Resta(Numero1, Numero2);
                }
                else if (Operaciones == "Multiplicacion")
                {
                    ViewBag.resultado = "El resultado es " + WS.Multiplicacion(Numero1, Numero2);
                }
                else if (Operaciones == "Division")
                {
                    ViewBag.resultado = "El resultado es " + WS.Division(Numero1, Numero2);
                }
                switch (Operacion)
                {
                    case  "Suma":
                        ViewBag.resultado = "El resultado es " + WS.Suma(Numero1, Numero2);
                        break;
                    case  "Resta":
                        ViewBag.resultado = "El resultado es " + WS.Resta(Numero1, Numero2);
                        break;
                    case "Multiplicacion":
                        ViewBag.resultado = "El resultado es " + WS.Multiplicacion(Numero1, Numero2);
                        break;
                    case "Division":
                        ViewBag.resultado = "El resultado es " + WS.Division(Numero1, Numero2);
                        break;
                }
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}