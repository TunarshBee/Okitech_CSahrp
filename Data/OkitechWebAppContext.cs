using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OkitechWebApp.Models;

namespace OkitechWebApp.Data
{
    public class OkitechWebAppContext : DbContext
    {
        public OkitechWebAppContext (DbContextOptions<OkitechWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<OkitechWebApp.Models.Register> Register { get; set; } = default!;

        public DbSet<OkitechWebApp.Models.Login> Login { get; set; } = default!;
    }
}
