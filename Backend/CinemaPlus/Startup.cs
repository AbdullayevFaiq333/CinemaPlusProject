using Buisness.Abstract;
using Buisness.Concret;
using CinemaPlus.AutoMapper;
using DataAccess.Abstract;
using DataAccess.Concret;
using DataAccess.Identity;
using Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaPlus
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


         
            services.AddControllersWithViews();
            var conectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<UserDbContext>(options =>
            {
                options.UseSqlServer(conectionString, builder =>
                {
                    builder.MigrationsAssembly(nameof(CinemaPlus));
                });
            });

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.User.RequireUniqueEmail = true;
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(10);
                options.Lockout.AllowedForNewUsers = true;

            }).AddEntityFrameworkStores<UserDbContext>().AddDefaultTokenProviders();


            services.AddScoped<IAboutUsBottomPartService, AboutUsBottomPartManager>();
            services.AddScoped<IAboutUsBottomPartDal, EFAboutUsBottomPartDal>();

            services.AddScoped<IAboutUsHeadPartService, AboutUsHeadPartManager>();
            services.AddScoped<IAboutUsHeadPartDal, EFAboutUsHeadPartDal>();

            services.AddScoped<IAdvertisementService, AdvertisementManager>();
            services.AddScoped<IAdvertisementDal, EFAdvertisementDal>();

            services.AddScoped<IBranchService, BranchManager>();
            services.AddScoped<IBranchDal, EFBranchDal>();

            services.AddScoped<ICampaignService, CampaignManager>();
            services.AddScoped<ICampaignDal, EFCampaignDal>();

            services.AddScoped<ICampaignDetailService, CampaignDetailManager>();
            services.AddScoped<ICampaignDetailDal, EFCampaignDetailDal>();

            services.AddScoped<ICinemaClubService, CinemaClubManager>();
            services.AddScoped<ICinemaClubDal, EFCinemaClubDal>();

            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IContactDal, EFContactDal>();

            services.AddScoped<IDolbyAtmosService, DolbyAtmosManager>();
            services.AddScoped<IDolbyAtmosDal, EFDolbyAtmosDal>();

            services.AddScoped<IFAQService, FAQManager>();
            services.AddScoped<IFAQDal, EFFAQDal>();

            services.AddScoped<IFooterService, FooterManager>();
            services.AddScoped<IFooterDal, EFFooterDal>();

            services.AddScoped<IFormatService, FormatManager>();
            services.AddScoped<IFormatDal, EFFormatDal>();

            services.AddScoped<IHallService, HallManager>();
            services.AddScoped<IHallDal, EFHallDal>();

            services.AddScoped<ILanguageService, LanguageManager>();
            services.AddScoped<ILanguageDal, EFLanguageDal>();

            services.AddScoped<IMovieService, MovieManager>();
            services.AddScoped<IMovieDal, EFMovieDal>();

            services.AddScoped<IMovieDetailService, MovieDetailManager>();
            services.AddScoped<IMovieDetailDal, EFMovieDetailDal>();

            services.AddScoped<IMovieFormatService, MovieFormatManager>();
            services.AddScoped<IMovieFormatDal, EFMovieFormatDal>();

            services.AddScoped<INavbarService, NavbarManager>();
            services.AddScoped<INavbarDal, EFNavbarDal>();

            services.AddScoped<INewsService, NewsManager>();
            services.AddScoped<INewsDal, EFNewsDal>();

            services.AddScoped<IPhotosService, PhotosManager>();
            services.AddScoped<IPhotosDal, EFPhotosDal>();

            services.AddScoped<IPlatiniumService, PlatiniumManager>();
            services.AddScoped<IPlatiniumDal, EFPlatiniumDal>();

            services.AddScoped<IRowService, RowManager>();
            services.AddScoped<IRowDal, EFRowDal>();

            services.AddScoped<IRulesService, RulesManager>();
            services.AddScoped<IRulesDal, EFRulesDal>();

            services.AddScoped<ISeatService, SeatManager>();
            services.AddScoped<ISeatDal, EFSeatDal>();

            services.AddScoped<ISecondFooterService, SecondFooterManager>();
            services.AddScoped<ISecondFooterDal, EFSecondFooterDal>();

            services.AddScoped<ISecondNavbarService, SecondNavbarManager>();
            services.AddScoped<ISecondNavbarDal, EFSecondNavbarDal>();

            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<IServiceDal, EFServiceDal>();

            services.AddScoped<ISessionService, SessionManager>();
            services.AddScoped<ISessionDal, EFSessionDal>();

            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ISocialMediaDal, EFSocialMediaDal>();

            services.AddScoped<ITariffService, TariffManager>();
            services.AddScoped<ITariffDal, EFTariffDal>();

            services.AddScoped<ITicketService, TicketManager>();
            services.AddScoped<ITicketDal, EFTicketDal>();





            services.AddCors(options =>
            {
                options.AddPolicy(name: "AllowOrigin",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:3000")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                    });
            });

        


            services.AddAutoMapper(typeof(AutoMapperProfile));

            services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CinemaPlus", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AppDbContext dbContext, UserManager<User> userManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CinemaPlus v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("AllowOrigin");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            var dataInitializer = new DataInitializer(dbContext, userManager);
             dataInitializer.SeedData();
        }
    }
}
