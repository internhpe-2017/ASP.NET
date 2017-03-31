using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tripmvc.Models;

namespace Tripmvc.Controllers
{
    public class RegistrationController : Controller
    {
       Registration[] reg = new Registration[];
        {
        // GET: Registration
        };
        
public ActionResult Index()
        {
            return View();
        }

        public IHttpActionResult SetProduct(string name,string familyid,string emailid,string gender,string age,string password,string confpassword)
        {
            var n = Registration.FirstOrDefault((p) => p.name == name);
            var f = Registration.FirstOrDefault((p) => p.familyid == familyid);
            var e = Registration.FirstOrDefault((p) => p.emailid == emailid);
            var g = Registration.FirstOrDefault((p) => p.gender == gender);
            var a = Registration.FirstOrDefault((p) => p.age == age);
            var p = Registration.FirstOrDefault((p) => p.password == password);
            var c = Registration.FirstOrDefault((p) => p.confpassword == confpassword);
            
            if (name == null || familyid==null||emailid==null||gender==null||age==null||password==null||confpassword==null )
            {
                return Registration();
            }
            return Login;
        }
    }
}

