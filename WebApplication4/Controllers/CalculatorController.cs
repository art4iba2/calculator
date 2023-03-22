using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;


namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(CalculatorModel model, string action)
        {
            if (action == "calculate")
            {
                if (ModelState.IsValid)
                {
                    switch (model.Operation)
                    {
                        case "+":
                            model.Result = model.FirstNumber + model.SecondNumber;
                            break;
                        case "-":
                            model.Result = model.FirstNumber - model.SecondNumber;
                            break;
                        case "*":
                            model.Result = model.FirstNumber * model.SecondNumber;
                            break;
                        case "/":
                            model.Result = model.FirstNumber / model.SecondNumber;
                            break;
                    }

                    ViewBag.Message = "Вычисление успешно.";
                }
                else
                {
                    ViewBag.Message = "Введены неверные данные.";
                }

                return View("Index", model);
            }
            else if (action == "clearr")
            {
                // Очистить модель и сбросить сообщение ViewBag
                model.FirstNumber2 = 0;
                model.Operation = "+";

                ViewBag.Message = "Поля очищены.";  

                return View("Index", model);
            }
            else
            {
                return View("Index", model);
            }
        }
    }

}
