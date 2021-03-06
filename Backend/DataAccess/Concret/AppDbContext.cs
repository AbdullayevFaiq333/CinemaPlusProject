using Entities.Models;
using Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concret
{
    public class AppDbContext: IdentityDbContext<User>
    {

        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
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
        public DbSet<Rules> Rules { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<SecondNavbar> SecondNavbars { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Photos> Photos { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<CampaignDetail> CampaignDetails { get; set; }
        public DbSet<SecondFooter> SecondFooters { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieDetail> MovieDetails { get; set; }
        public DbSet<MovieFormat> MovieFormats { get; set; }
        public DbSet<Format> Formats { get; set; }
        public DbSet<Session> Sessions { get; set; }        
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Row> Rows { get; set; }
        public DbSet<Seat> Seats { get; set; }

    }
}
