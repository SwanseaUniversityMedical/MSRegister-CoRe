using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MSRegister_CoRe.Data;
using MSRegister_CoRe.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MSRegister_CoRe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _applicationDbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromBody] Models.Root Data)
        {
            // do a test
            if (Data == null || Data.StudyId == "" || Data.Tests == null || Data.Tests.Count == 0)
                return View("Error");
            else
            {                
                _applicationDbContext.Add(Data);
                _applicationDbContext.SaveChanges();

                return View("Save2");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
