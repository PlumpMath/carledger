﻿using System.Threading.Tasks;
using Carledger.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carledger.Controllers
{
    public class OwnerController : Controller
    {
        // GET
        public async Task<IActionResult> Index()
        {
            return View(await CarledgerService.GetOwners());
        }
        
        
    }
}