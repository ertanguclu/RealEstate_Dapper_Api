﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Areas.EstateAgent.Controllers
{
    public class MyAdvertsController : Controller
    {
        [Area("EstateAgent")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
