using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
    public class ContentDto
    {
        public List<DolbyAtmosDto> DolbyAtmosDto { get; set; }
        public List<PlatiniumDto> PlatiniumDto { get; set; }
        public List<ServiceDto> ServiceDto { get; set; }
        public List<CinemaClubDto> CinemaClubDto { get; set; }
        public List<NavbarDto> NavbarDto { get; set; }
        public List<FooterDto> FooterDto { get; set; }
        public List<SocialMediaDto> SocialMediaDto { get; set; }
        public List<NewsDto> NewsDto { get; set; }
    }
}
