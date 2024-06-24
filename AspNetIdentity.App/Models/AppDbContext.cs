using AspNetIdentity.App.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetIdentityApp.Models;

public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
{



    // base : miras aldığımız sınıfı consturctora gönderir
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}
