using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplication.Models;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            var Phone1 = new List<Phone> {
                new Phone {PhoneName ="oneplus 6t" , ScreenSize = 123 , Manufacturer = "onplus", DateRelease = new DateTime(2000,12,06),MSRP = 1561651},
                new Phone {PhoneName ="Iphone 11" , ScreenSize = 123 , Manufacturer = "apple", DateRelease = new DateTime(2000,12,06),MSRP = 468435},
                new Phone {PhoneName ="S11" , ScreenSize = 123 , Manufacturer = "Samsung", DateRelease = new DateTime(2000,12,06),MSRP = 4566551}

            };
            return View(Phone1);
        }
    }
}