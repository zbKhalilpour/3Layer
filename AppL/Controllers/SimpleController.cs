using BL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

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

        public ActionResult Update(M_PhoneBook m_PhoneBook)
        {
            var bz = new PhoneBook();
            bz.UpdatePerson(m_PhoneBook);
            return Json(new {Message="succses" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Delete(int id)
        {
            var bz = new PhoneBook();
            bz.DeletePerson(id);
            return Json(new { Message = "succses" }, JsonRequestBehavior.AllowGet);
        }


    }
}