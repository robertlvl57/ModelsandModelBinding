using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsandModelBinding.Models;

namespace ModelsandModelBinding.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //When data is posted to /Student/Register this action will execute
        [HttpPost]
        public IActionResult Register(IFormCollection data)
        {
            //Validate input (lot's fo work!)
            //Server-side and client-side
            //Add error messages on page to notify user

            Student stu = new Student()
            {
                FullName = data["full-name"],
                ProgramOfChoice = data["program"],
                DateOfBirth = Convert.ToDateTime(data["dob"]),
                HomeAddress = data["address"]
            };

            // Add to database
            return View();
        }

        //Registration done with Model Binding!
        [HttpGet]
        public IActionResult RegisterMB()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterMB(Student s)
        {
            // This verifies all data annotations in the class are valid
            if (ModelState.IsValid)
            {
                // Add to database
                //Display success message
            }
            return View();
        }
    }
}