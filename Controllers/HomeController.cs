using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEngineering.Models;

namespace WebEngineering.Controllers
{
    public class HomeController : Controller
    {
        List<Employee> employees_data = new List<Employee>();

        // GET: Home
        public ActionResult Index()
        {
            employees();
            return View(employees_data);
        }

        public ActionResult Create(Employee employee)
        {
            return View(employee);
        }

        [NonAction]
        public List<Employee> employees()
        {
            employees_data.Add(
                new Employee(
                    1,
                    "Abdul Moiz1", 
                    "sp21bsse0005@maju.edu.pk",
                    21,
                    "0311xxxxxxx", 
                    new DateTime(2021, 9, 1), 
                    "Pakistan"
                )
             );
            employees_data.Add(
                new Employee(
                    2,
                    "Abdul Moiz2",
                    "sp21bsse0005@maju.edu.pk",
                    21,
                    "0311xxxxxxx",
                    new DateTime(2021, 9, 1),
                    "Pakistan"
                )
             );
            employees_data.Add(
                new Employee(
                    3,
                    "Abdul Moiz3",
                    "sp21bsse0005@maju.edu.pk",
                    21,
                    "0311xxxxxxx",
                    new DateTime(2021, 9, 1),
                    "Pakistan"
                )
             );

            return employees_data;
        }
    }
}