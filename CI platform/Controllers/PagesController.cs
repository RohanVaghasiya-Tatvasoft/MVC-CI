﻿using Microsoft.AspNetCore.Mvc;

namespace CI_platform.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult platformLandingPage()
        {
            return View();
        }
    }
}