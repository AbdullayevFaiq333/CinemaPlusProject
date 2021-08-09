﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Language:IEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<DolbyAtmos> DolbyAtmos { get; set; }
        public ICollection<Platinium> Platiniums { get; set; }
        public ICollection<Service> Services { get; set; }
        public ICollection<CinemaClub> CinemaClubs { get; set; }
        public ICollection<Navbar> Navbars { get; set; }
        public ICollection<Footer> Footers { get; set; }
        
        public ICollection<News> News { get; set; }
        public ICollection<AboutUsHeadPart> AboutUsHeadParts { get; set; }
        public ICollection<AboutUsBottomPart> AboutUsBottomParts { get; set; }
        public ICollection<Rules> Rules { get; set; }
        public ICollection<FAQ> FAQs { get; set; }
        public ICollection<SecondNavbar> SecondNavbars { get; set; }
        public ICollection<Branch> Branches { get; set; }
        public ICollection<Campaign> Campaigns { get; set; }
        public ICollection<CampaignDetail> CampaignDetails { get; set; }
        public ICollection<SecondFooter> SecondFooters { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public ICollection<MovieDetail> MovieDetails { get; set; }
        public ICollection<Format> Formats { get; set; }
        public ICollection<Hall> Halls { get; set; }
    }
}
