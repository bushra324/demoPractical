using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Student()
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Sanila",
                Gender = "Female",
            };
            return View(student);


        }
    }
}
