using AutoMapper;
using Entities.Dto;
using Entities.Models;
using Entity.Dto;
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
            CreateMap<AboutUsHeadPart, AboutUsHeadPartDto>().ReverseMap();
            CreateMap<AboutUsBottomPart, AboutUsBottomPartDto>().ReverseMap();
            CreateMap<Language, LanguageDto>().ReverseMap();
            CreateMap<Rules, RulesDto>().ReverseMap();
            CreateMap<FAQ, FAQDto>().ReverseMap();
            CreateMap<Advertisement, AdvertisementDto>().ReverseMap();
            CreateMap<SecondNavbar, SecondNavbarDto>().ReverseMap();
            CreateMap<SecondFooter, SecondFooterDto>().ReverseMap();
            CreateMap<Branch, BranchDto>().ReverseMap();
            CreateMap<Campaign, CampaignDto>().ReverseMap();
            CreateMap<CampaignDetail, CampaignDetailDto>().ReverseMap();
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<Format, FormatDto>().ReverseMap();
            CreateMap<Hall, HallDto>().ReverseMap();
            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<MovieDetail, MovieDetailDto>().ReverseMap();
            CreateMap<Photos, PhotosDto>().ReverseMap();
            CreateMap<Row, RowDto>().ReverseMap();
            CreateMap<Seat, SeatDto>().ReverseMap();
            CreateMap<Session, SessionDto>().ReverseMap();
            CreateMap<Tariff, TariffDto>().ReverseMap();
            CreateMap<Ticket, TicketDto>().ReverseMap();
        }
    }
}
