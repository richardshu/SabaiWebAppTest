using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SabaiWebApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SabaiWebApp.Controllers
{
    public class PatientController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            SabaiDataContext context = HttpContext.RequestServices.GetService(typeof(SabaiWebApp.Models.SabaiDataContext)) as SabaiDataContext;

            return View(context.GetAllPatients());
        }
    }
}