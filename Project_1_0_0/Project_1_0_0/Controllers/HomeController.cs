using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SimpleGame.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Play(int guess)
        {
            int number = new Random().Next(1, 11);

            if (guess == number)
            {
                ViewBag.Message = "Браво! Позна числото, което беше " + number;
            }
            else
            {
                ViewBag.Message = "Не позна! Числото беше " + number + ". Опитай пак!";
            }


            return View();
        }
    }
}