﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPlantilla.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Vervideos()
        {
            return View();
        }

        public ActionResult Agregarvideo()
        {
            return View();
        }

        public ActionResult Eliminarvideo()
        {
            return View();
        }

        public ActionResult Modificarvideo()
        {
            return View();
        }
    }
}
