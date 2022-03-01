using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                var signups = db.Users;
                var userVms = new List<UserVM>();
                foreach (var signup in signups)
                {
                    var signupVm = new UserVM();
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVm.Id = signup.Id;
                    userVms.Add(signupVm);
                }
                return View(userVms);
            }

            
        }
        public ActionResult Unsubscribe(int id)
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                var signup = db.Users.Find(id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
                
            }
            return RedirectToAction("Index");
        }
    }
}