using AutoMapper;
using Entities.Dto;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaPlus.AutoMapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<DolbyAtmos, DolbyAtmosDto>().ReverseMap();
            CreateMap<Platinium, PlatiniumDto>().ReverseMap();
            CreateMap<Service, ServiceDto>().ReverseMap();
            CreateMap<CinemaClub, CinemaClubDto>().ReverseMap();
            CreateMap<Navbar, NavbarDto>().ReverseMap();
            CreateMap<Footer, FooterDto>().ReverseMap();
            CreateMap<SocialMedia, SocialMediaDto>().ReverseMap();
            CreateMap<News, NewsDto>().ReverseMap();
        }
    }
}
