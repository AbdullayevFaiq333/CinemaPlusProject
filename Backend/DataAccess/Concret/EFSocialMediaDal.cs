using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concret
{
    public class EFSocialMediaDal : EFRepositoryBase<SocialMedia, AppDbContext>, ISocialMediaDal
    {
    }
}
