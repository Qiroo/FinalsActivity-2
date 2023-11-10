using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalsActivity_2.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IT.ELEC1C.Module8.MVC.Controllers
{
    public class BrandController : Controller
    {
        private IBrandDataService _service;

        public BrandController(IBrandDataService service)
        {
            _service = service;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var brands = await _service.GetBrandsAsync();
            return View(brands);
        }
    }
}