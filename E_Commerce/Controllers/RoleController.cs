using E_Commerce.Data;
using Microsoft.AspNetCore.Mvc;
using E_Commerce.ViewModel;

namespace E_Commerce.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddRole()
        {
            return View();
        }
        
    }
}
