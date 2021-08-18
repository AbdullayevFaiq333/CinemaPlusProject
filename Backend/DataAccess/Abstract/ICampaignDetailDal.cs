using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICampaignDetailDal : IRepository<CampaignDetail>
    {
        Task<CampaignDetail> GetCampaignDetailAsync(string languageCode, int id);
        Task<bool> CheckCampaignDetail(Expression<Func<CampaignDetail, bool>> expression);


    }
}
