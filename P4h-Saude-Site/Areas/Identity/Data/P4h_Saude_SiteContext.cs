using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using P4h_Saude_Site.Areas.Identity.Data;

namespace P4h_Saude_Site.Data;

public class P4h_Saude_SiteContext : IdentityDbContext<P4h_Saude_Site_UserClass>
{
    public P4h_Saude_SiteContext(DbContextOptions<P4h_Saude_SiteContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
