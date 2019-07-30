using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using WebApp.Models;
using WebApp.Repository.IRepo;
using WebApp.Repository.Repo;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        IStudentRepo studentRepo;
        public async Task<IActionResult> Index()
        {
            studentRepo = new StudentRepo();

            //get all data
            var getalldata = studentRepo.GetAll();

            //get single data
            var singledata = await studentRepo.Get(1);

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student model)
        {
            studentRepo = new StudentRepo();
            await studentRepo.Add(model);
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Student model)
        {
            studentRepo = new StudentRepo();
            await studentRepo.Update(model);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(long id)
        {
            studentRepo = new StudentRepo();
            await studentRepo.Delete(id);
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
