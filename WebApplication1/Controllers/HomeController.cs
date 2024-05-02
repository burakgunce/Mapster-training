using Mapster;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Model1 model1 = new Model1()
            {
                Id = 1,
                Name = "Test",
                Address = "Istanbul"
            };

            var model = model1.Adapt<Model2>();
            
            return View();
        }
        public IActionResult Deneme()
        {
            var config = new TypeAdapterConfig();

            // DTO nesnesinden User nesnesine dönüşümü yapılandırma
            config.NewConfig<UserDTO, User>()
                .Map(dest => dest.FullName, src => $"{src.FirstName} {src.LastName}");
            
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
        //student ıd name surname address    crud    listelemede fullname mapster formember arastır    static clas static list prop
    }
}