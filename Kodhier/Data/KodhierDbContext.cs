﻿using Kodhier.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kodhier.Data
{
    public class KodhierDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Pizza> Pizzas { get; set; }

        public KodhierDbContext(DbContextOptions<KodhierDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
