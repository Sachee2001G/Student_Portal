﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]

        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await dbContext.Students.FindAsync(id);

            return View(student);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(Student viewModel)
        {
            var student = await dbContext.Students.FindAsync(viewModel.Id);

            if (student is not null) 
            { 
                student.Name = viewModel.Name;
                student.Email = viewModel.Email;
                student.Phone = viewModel.Phone;
                student.Subscribed = viewModel.Subscribed;

                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Students");
        }


        [HttpPost]

        public async Task<IActionResult> Delete(Student viewModel)
        {
            var student = await dbContext.Students
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == viewModel.Id);

            if (student is not null)
            {
                dbContext.Students.Remove(viewModel);
                
                await dbContext.SaveChangesAsync();

            }

            return RedirectToAction("List", "Students");
        }


    }
}
