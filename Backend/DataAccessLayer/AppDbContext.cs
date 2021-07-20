using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<DolbyAtmos> DolbyAtmos { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Platinium> Platiniums { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<CinemaClub> CinemaClubs { get; set; }
        public DbSet<Navbar> Navbars { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<AboutUsHeadPart> AboutUsHeadParts { get; set; }
        public DbSet<AboutUsBottomPart> AboutUsBottomParts { get; set; }
    }
}
