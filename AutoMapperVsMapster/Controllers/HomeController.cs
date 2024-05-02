using AutoMapper;
using AutoMapperVsMapster.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AutoMapperVsMapster.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Model1 model1 = new Model1()
            {
                Id = 1,
                FirstName = "Burak",
                LastName = "Gunce"
            };

            //Model2 model2 = new Model2()
            //{
            //    Id = model1.Id,
            //    Name = model1.Name,
            //    Address = model1.Address
            //};

            Model2 model2 = new Model2();
            var modelx = _mapper.Map(model1, model2);

            var model = _mapper.Map<Model2>(model1); // hazırda nesne olmasına gerek yok direk mapleyebilirsin


            ModelX modelX = new ModelX()
            {
                Id = 1,
                PostCode = "61"
            };
            var modely = _mapper.Map<ModelY>(modelX);

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