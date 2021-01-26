﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFIlmi.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Pozdravljen(string ime="Barbara",int num=1)
        {
            ViewBag.Message = "Pozdravljen, " + ime;
            ViewBag.Num = num;
            return View();
        }
        public string Nova(int id = 1)
        {
            return "Vrednost id je " + id;
        }
    }
}