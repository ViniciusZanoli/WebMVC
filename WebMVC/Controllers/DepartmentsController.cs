using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departments> list = new List<Departments>();
            list.Add(new Departments { id = 1, name = "Eletronics" });
            list.Add(new Departments { id = 2, name = "Fashion" });

            return View(list);
        }
    }
}