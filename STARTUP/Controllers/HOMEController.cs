﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STARTUP.Controllers
{
    public class HOMEController : Controller
    {
        // GET: HOME
        public ActionResult Index()
        {
            return View();
        }
    }
}