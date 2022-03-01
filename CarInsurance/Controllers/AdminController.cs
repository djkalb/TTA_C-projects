using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insuree = db.Insurees.ToList();
                var insurees = new List<InsureeVM>();
                foreach (var entry in insuree)
                {
                    var insureeVm = new InsureeVM();
                    insureeVm.FirstName = entry.FirstName;
                    insureeVm.LastName = entry.LastName;
                    insureeVm.EmailAddress = entry.EmailAddress;
                    //this should work since the db is updated with the new quote every time
                    insureeVm.Quote = entry.Quote;
                    insurees.Add(insureeVm);
                }

                return View(insurees);
            }
                
        }
    }
}
