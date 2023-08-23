using CvProject.Context;
using CvProject.Models;
using CvProject.Views.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CvProject.Controllers
{
	[AllowAnonymous]

	public class LoginController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

       
        public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
		
		[HttpPost]
        public async Task<IActionResult> Index(LoginViewModel loginViewModel)
        {
            var result = await _signInManager.PasswordSignInAsync(loginViewModel.userName, loginViewModel.password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","About");
            }
            else
            {
                
                return RedirectToAction("Index");
            }
            return View();

           
        }

       
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp (RegisterViewModel registerViewModel)
        {
            IdentityUser identityUser = new IdentityUser()
            {
                Id = "1", //id otomatik artmıyor değişecek
                UserName = registerViewModel.userName,
                Email = registerViewModel.mail,

            };
            if (registerViewModel.password == registerViewModel.passwordConfirm)
            {
                var result = await _userManager.CreateAsync(identityUser, registerViewModel.password);
                if (result.Succeeded) // işlemler başarılı olursa
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(registerViewModel);
        }
        public async Task<IActionResult> Logout() //asenkron olduğundan Task yapıldı
        {
            await HttpContext.SignOutAsync(); // oturumu kapat.

            return RedirectToAction("Index");
        }
    }
}
