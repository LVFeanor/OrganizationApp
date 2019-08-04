using OrganizationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace OrganizationApp.Controllers
{
    public class HomeController : Controller
    {
        OrganizationContext db = new OrganizationContext();
        public ActionResult Index()
        {

            var founders = db.Founders.Include(p => p.Organizations);
            return View(founders.ToList());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public string Add(Organization organization, Founder founder)
        {
            db.Organizations.Add(organization);
            db.Founders.Add(founder);
            founder.OrganizationId = organization.Id;
            db.SaveChanges();
            return "Организация " + organization.Title + " успешно добавлена в базу данных.";
            //return RedirectToAction("Index");
        }
        public ActionResult AddFounder()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Array()
        {
            return View();
        }

        [HttpPost]
        public string Array(List<string> names)
        {
            string fin = "";
            for (int i = 0; i < names.Count; i++)
            {
                fin += names[i] + "; ";
            }
            return fin;
        }
    }
}