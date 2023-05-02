using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIdentity.Areas.Identity.Data;

public class NomeDoSeuDbContext : IdentityDbContext<IdentityUser>
{
    public NomeDoSeuDbContext(DbContextOptions<NomeDoSeuDbContext> options)        : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        base.OnConfiguring(options);

    }

}

