using System;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Collections;
using System.Data;

namespace ComparatorWeb.Controllers
{
    public class CompController : Controller 
    {   
        [HttpGet]
        public ActionResult Compare()
        {
           return View(); 
        }
        [HttpPost]
        public ActionResult Compare(string firstNumber, string secondNumber)
        {
            double numberOne = int.Parse(firstNumber);
            double numberTwo = int.Parse(secondNumber);
            double sqrtnumberOne = Math.Sqrt(numberOne);
            double sqrtnumberTwo = Math.Sqrt(numberTwo);
            double result = sqrtnumberOne - sqrtnumberTwo;

            ViewBag.numberOne = numberOne;
            ViewBag.numberTwo = numberTwo;
            ViewBag.SqrtnumberOne = sqrtnumberOne;
            ViewBag.SqrtnumberTwo = sqrtnumberTwo;
            ViewBag.Result = result;
            return View();
        }

        
    }
}