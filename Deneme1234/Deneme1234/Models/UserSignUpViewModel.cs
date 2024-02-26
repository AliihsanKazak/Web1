using System.ComponentModel.DataAnnotations;

namespace Deneme1234.Models;

public class UserSignUpViewModel
{
     
     [Required(ErrorMessage = "Lütfen ad soyad giriniz")]
     public string NameSurname { get; set; }
     
     
     [Required(ErrorMessage = "Lütfen şifre giriniz")]
     public string Password { get; set; }
     
     
     [Compare("Password",ErrorMessage = "Şifreler uyuşmuyor.")]
     public string ConfirmPassword { get; set; }
     
     
     [Required(ErrorMessage = "Lütfen Mail giriniz")]
     public string Mail { get; set; }
     
     
     [Required(ErrorMessage = "Lütfen Kullanıcı Adı giriniz")]
     public string UserName { get; set; }
     
     
    
}