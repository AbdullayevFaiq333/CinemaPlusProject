using Entities.Interfaces;
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
        public ICollection<SocialMedia> SocialMedias { get; set; }
        public ICollection<News> News { get; set; }
        public ICollection<AboutUsHeadPart> AboutUsHeadParts { get; set; }
        public ICollection<AboutUsBottomPart> AboutUsBottomParts { get; set; }
        public ICollection<Rules> Rules { get; set; }
        public ICollection<FAQ> FAQs { get; set; }
    }
}
