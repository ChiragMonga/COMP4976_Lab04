using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lab04.Models;

namespace Lab04.Data
{
    public class ApplicationDbContext : IdentityDbContext {
    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder) {
        base.OnModelCreating(builder);
        builder.Entity<City>().Property(m => m.CityName).IsRequired();

        builder.Entity<Province>().Property(p => p.ProvinceName).HasMaxLength(30);

        builder.Entity<Province>().ToTable("Province");
        builder.Entity<City>().ToTable("City");

        builder.Seed();
    }

    public DbSet<Province> Provinces { get; set; }
    public DbSet<City> Cities { get; set; }
}

}
