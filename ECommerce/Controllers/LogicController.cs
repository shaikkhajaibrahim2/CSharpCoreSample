﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class LogicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}