using Entity_Layer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project_OOP_.Net_7.Models;

namespace Project_OOP_.Net_7.Controllers
{
    public class RegisterController1 : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController1(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public async Task <IActionResult> Index(UserRegisterViewModel model)
        {
            AppUser appUser = new AppUser()
            {
                Name=model.Name,SurName=model.SurName,Email=model.Email,UserName=model.UserName
            };
            if(model.Password==model.ConfirmPassword)
            {
                var result=await _userManager.CreateAsync(appUser,model.Password);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(model);
        }
    }
}
