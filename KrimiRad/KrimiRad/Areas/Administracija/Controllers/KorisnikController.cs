﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KrimiRad.Areas.Administracija.Controllers
{
    public class KorisnikController : Controller
    {
        // GET: Administracija/Korisnik
        public PartialViewResult Index() {
            return PartialView();
        }
    }
}