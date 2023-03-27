﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authorization.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {        
        public IActionResult Display()
        {
            return View();
        }
    }
}
