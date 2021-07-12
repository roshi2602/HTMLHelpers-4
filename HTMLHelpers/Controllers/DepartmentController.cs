using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLHelpers.Models;
namespace HTMLHelpers.Controllers
{
    //using department and company model
    public class DepartmentController : Controller
    {
        // GET: Department
        [HttpGet]  //this is for retrive info from server
        public ActionResult GetRadioButton()
        {
            //creating company object
            Company cc = new Company();
            return View(cc);
        }

        [HttpPost]
        public string GetRadioButton(Company cc)
        {
            if(string.IsNullOrEmpty(cc.Cname))    //using property of Company i.e. Cname
            {
                return "not working";

            }
            else
            {
                return "working" + cc.Cname;
            }
        }
    }
}