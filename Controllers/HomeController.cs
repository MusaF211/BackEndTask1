using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Intro.Models;

namespace Web_Intro.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Student> _students;
        private readonly List<Group> _groups;

        public HomeController()
        {
            _students = new List<Student>
            {
                new Student{id=1, Name="Musa", Surname="Dadashov", Grade= 17, GroupId = 1},
                new Student{id=2, Name="Musa", Surname="Dadashov", Grade= 17, GroupId = 2},
                new Student{id=3, Name="Musa", Surname="Dadashov", Grade= 17, GroupId = 1},
                new Student{id=4, Name="Musa", Surname="Dadashov", Grade= 17, GroupId = 3},
                new Student{id=5, Name="Musa", Surname="Dadashov", Grade= 17, GroupId = 3},
                new Student{id=6, Name="Musa", Surname="Dadashov", Grade= 17, GroupId = 2},
            };

            _groups = new List<Group>
            {
                new Group{GroupId = 1, GroupName="P129"},
                new Group{GroupId = 2, GroupName="P128"},
                new Group{GroupId = 3, GroupName="P127"},
            };
        }
        public IActionResult Index(int? id)
        {
            //if (id != 0) return Json(_students.Find(s => s.id == id));

            return View(_groups);
            
        }

        public IActionResult Student(int? id)
        {
            if (id == null) return BadRequest();

            List<Student> students = _students.FindAll(s => s.GroupId == id);

            return View(students);
        }

       
    }
}
