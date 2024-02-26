using System.Dynamic;
using Deneme1234.Concrete;
using Deneme1234.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Deneme1234.Controllers;

[AllowAnonymous]
public class RegisterController : Controller
{
    
    private readonly UserManager<Kullanici> _userManager;

    public RegisterController(UserManager<Kullanici> userManager)
    {
        _userManager = userManager;

    }



    [HttpGet]
    public IActionResult Kayıt()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Kayıt(UserSignUpViewModel p)
    {
        if (ModelState.IsValid)
        {
            Kullanici kullanici = new Kullanici
            {
                NameSurname = p.NameSurname,
                Email = p.Mail,
                UserName = p.UserName
            };



            var result = await _userManager.CreateAsync(kullanici, p.Password);
            //Kayıt olurken user'a rol atama 

            
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(kullanici, "User");

                return RedirectToAction("Index", "Home");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
        }
        return View();
    }

}
