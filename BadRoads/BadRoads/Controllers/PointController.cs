﻿using BadRoads.Filters;
using BadRoads.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BadRoads.Controllers
{
    [Culture]
    public class PointController : Controller
    {
        BadroadsDataContext db = new BadroadsDataContext();      // объект модели

        [HttpPost]
        public ActionResult CreatePoint(Point Pnt)
        {
            if (ModelState.IsValid)
            {
                db.Points.Add(Pnt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Pnt);
        }
    }
}