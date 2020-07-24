using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class BaseController : Controller
    {
        private IStudentService studentService { get; set; }

        public BaseController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        public BaseController()
        {
        }

        
    }
}