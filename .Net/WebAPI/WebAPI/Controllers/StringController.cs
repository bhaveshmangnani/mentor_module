﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace WebAPI.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiController]
    public class StringController : Controller
    {
        /*[HttpGet]
        public IActionResult Index()
        {
            return View();
        }*/

        [HttpGet]
        public IEnumerable<string> Hw()
        {
            return new string[] { "Hello world" };
        }
        /*
        [HttpGet]
        public IEnumerable<string> hw1()
        {
            return new string[] { "Hello world 1" };
        }*/
    }
}
