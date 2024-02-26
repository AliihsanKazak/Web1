using Deneme1234.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace  Deneme1234.Controllers;

[AllowAnonymous]
public class AccountController : Controller
{

    //Bu yapılar identity'nin kendi yapıları
    private readonly UserManager<Kullanici> _userManager;
    private readonly SignInManager<Kullanici> _signInManager;

    public AccountController(UserManager<Kullanici> userManager, SignInManager<Kullanici> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    // GET

    [HttpGet]

    public IActionResult Login()
    {
        ViewBag.hata = false;
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> Login(UserSignInViewModel p)
    {

        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByNameAsync(p.username);
            if (user == null)
            {
                ViewBag.hata = true;

                return View();
            }
            var result =
                await _signInManager.PasswordSignInAsync(user, p.password, isPersistent: false,
                    lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();

        return RedirectToAction("Index", "Home");
    }


}