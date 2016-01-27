using System.Threading.Tasks;
using DependencyInjectionAndASPNETCore.Services;
using Microsoft.AspNet.Mvc;

namespace DependencyInjectionAndASPNETCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderStore _orderStore;

        public HomeController(IOrderStore orderStore)
        {
            _orderStore = orderStore;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await _orderStore.GetAllAsync();
            return View(orders);
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
