using BL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppL.Controllers
{
    public class SimpleController : Controller
    {  
        public ActionResult Index()
        {
            var bz = new PhoneBook();
            ViewBag.List = bz.GetInfo(); 
            return View();
        }

        public ActionResult Create(M_PhoneBook m_PhoneBook)
        {
            var bz = new PhoneBook();
            bz.Insert(m_PhoneBook);
            return Json( new { }, JsonRequestBehavior.AllowGet);
        }


    }
}