using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScanGunBasicTemplate.DataAccess;

namespace ScanGunBasicTemplate.Controllers
{
    public class HomeController : Controller
    {
        #region "Global Variables"

        #endregion

        #region "Action Methods"
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HomePage()
        {
            return View();
        }
        #endregion

        #region "Helper Function(s) "

        #endregion 

    }
}