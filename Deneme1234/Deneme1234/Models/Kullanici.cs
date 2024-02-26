using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Deneme1234.Models;

public class Kullanici: IdentityUser
{
    public string NameSurname { get; set; }
    
    
}
