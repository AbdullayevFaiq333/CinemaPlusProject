using Core.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IPhotosDal : IRepository<Photos>
    {
        Task<bool> CheckPhotos(Expression<Func<Photos, bool>> expression);

    }
}
