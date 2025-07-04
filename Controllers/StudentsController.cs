using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using student_portal.Data;
using student_portal.Models;
using student_portal.Models.Entities;
//using System.ComponentModel.DataAnnotations;
//using System.Runtime.CompilerServices;

namespace student_portal.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public StudentsController(ApplicationDbContext dbContext)
        {
           this.dbContext = dbContext;
        }

     

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]

        // Making Asynchronous
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student =new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Subscribed = viewModel.Subscribed
            };

            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();


            return View();
        }


        [HttpGet]

        public async Task<IActionResult> List()
        {
            var students = await dbContext.Students.ToListAsync();
            return View(students);
        }
    }
}
