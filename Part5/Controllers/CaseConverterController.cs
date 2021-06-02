using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Part5.Models;
using Part5.Helper;

namespace Part5.Controllers
{
    public class CaseConverterController : Controller
    {
        
        private StringHolderDbContext db = new StringHolderDbContext();
        // GET: CaseConverter
        public ActionResult CaseConverter()
        {
            
            
            return View();
        }

        [HttpPost]
        public ActionResult CaseConverter(StringHolder stringH)
        {
            if (ModelState.IsValid)
            {
                
                stringH.Lowercase = ProcessString.Convert(stringH.Lowercase, 1);
                stringH.Uppercase = ProcessString.Convert(stringH.Uppercase, 2);
                stringH.Inverted = ProcessString.Convert(stringH.Inverted, 3);
                db.strings.Add(stringH);
                db.SaveChanges();
                return RedirectToAction("Convert");
            }

            return View();
        }

        

        public ActionResult Convert()
        {
            return View(db.strings.ToList());
        }
    }
}