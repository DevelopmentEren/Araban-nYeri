using ArabanınYeri.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArabanınYeri.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Apply()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
            Repository.AddStudent(student);
            return View("Thanks", student);
            }

            else
            {
                return View();
            }
        }

        public ViewResult List()
        {
            var liste = Repository.Students.Where(i => i.WillAttend == true);
            return View(liste);
        }

    }
}
