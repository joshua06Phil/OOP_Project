﻿using Microsoft.AspNetCore.Mvc;

namespace OOP_Project.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
