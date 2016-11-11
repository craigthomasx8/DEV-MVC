using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IGSDeveloperTest.Models;
using IGSDeveloperTest.Datamodel;

namespace IGSDeveloperTest.Controllers
{
    public class AdministrationController : Controller
    {
        // GET: Administration
        public ActionResult Index()
        {
            var vm = new AdministrationViewModels();
            var en = new IGSEntities();

            vm.CompanyList = (from x in en.Companies select x).ToList();
            vm.GenderList = (from x in en.Genders select x).ToList();
            vm.TitleList = (from x in en.Titles select x).ToList();

            return View(vm);
        }
    }
}