using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Repository.IRepo;
using WebApp.Repository.Repo;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            IStudentRepo studentRepo = new StudentRepo();

            //get all data
            var getalldata = studentRepo.GetAll();

            //get single data
            var singledata = await studentRepo.Get(1);

            //modify entity data
            singledata.Address = "Address"+Guid.NewGuid().ToString();
            var returnresult = studentRepo.Update(singledata);

            // Entity Add
            //  studentRepo.Add(singledata);


            // Entity Delete
            //  studentRepo.Delete(1);

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
