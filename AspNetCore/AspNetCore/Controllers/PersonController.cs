using AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var person = new Person();
            person.Name = "Davis";
            person.Surname = "Simanis";
            person.Email = "Some@sample.email";
            person.Age = 89;
            person.Address = "You would like to know";
            person.IsMale = true;
            return View(person);

        }
    }
}
