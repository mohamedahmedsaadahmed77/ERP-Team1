﻿using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class StudentController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        public ActionResult Profile()
        {
            return View();
        }
    }
}