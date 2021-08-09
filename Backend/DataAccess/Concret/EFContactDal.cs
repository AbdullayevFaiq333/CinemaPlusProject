using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concret
{
    public class EFContactDal : EFRepositoryBase<Contact, AppDbContext>, IContactDal
    {
    }
}
