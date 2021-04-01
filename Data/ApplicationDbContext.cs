using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using KlubPrátelTaborovychOhnu.Models;

namespace KlubPrátelTaborovychOhnu.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Clanek> Clanek { get; set; }
        public DbSet<Osoba> Osoba { get; set; }
    }
}
