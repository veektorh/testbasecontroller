using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IStudentService studentService;
        private readonly ICacheManager cacheManager;

        public HomeController(IStudentService studentService, ICacheManager cacheManager) : base()
        {
            this.studentService = studentService;
            this.cacheManager = cacheManager;
        }
        public IActionResult Index()
        {
            var model = studentService.GetName();
            cacheManager.Set("name", "victor");
            var name = cacheManager.Get("name");
            return View();
        }

        public IActionResult Test()
        {
            var name = cacheManager.Get("name");
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
