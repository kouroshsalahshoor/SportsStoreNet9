using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Repository.IRepository;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository _repository;

        //private readonly ILogger<HomeController> _logger;

        public HomeController(IStoreRepository repository)
        {
            _repository = repository;
        }
        //public HomeController(ILogger<HomeController> logger, IStoreRepository repository)
        //{
        //    _logger = logger;
        //    _repository = repository;
        //}

        public IActionResult Index() => View(_repository.Products);

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
