// ----------------------------------------------------------------------------------------------------------------------
// Author: Tanveer Yousuf (@tanveery)
// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd. All rights reserved.
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System.Web.Mvc;
using System.Data.Entity;
using System.Linq;
using Ejyle.DevAccelerate.List.EF;
using System.Collections.Generic;
using System.Globalization;

namespace Ejyle.DevAccelerate.Samples.AspNetMvc.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}