﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusinessLMSWeb.Controllers
{

    [Authorize]
    public class DashboardController : BaseWebController
    {

        public ActionResult Index()
        {
            return View();
        }

    }
}