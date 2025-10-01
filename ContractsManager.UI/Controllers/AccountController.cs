using ContactsManager.Core.DTO;
using CURDDEMO.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ContractsManager.UI.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterDTO registerDTO)
        {
            return RedirectToAction(nameof(PersonsController.Index), "Person");
        }

    }
}
