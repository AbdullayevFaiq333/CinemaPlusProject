﻿using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class DolbyAtmosManager : IDolbyAtmosService
    {
        private readonly IDolbyAtmosDal _dolbyAtmosDal;

        public DolbyAtmosManager(IDolbyAtmosDal dolbyAtmosDal)
        {
            _dolbyAtmosDal = dolbyAtmosDal;
        }
        public async Task<DolbyAtmos> GetDolbyAtmosWithIdAsync(int id)
        {
            return await _dolbyAtmosDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<DolbyAtmos>> GetAllDolbyAtmosAsync()
        {
            return await _dolbyAtmosDal.GetAllAsync();
        }


        public Task<bool> AddDolbyAtmosAsync(DolbyAtmos dolbyAtmos)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDolbyAtmosAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateDolbyAtmosAsync(DolbyAtmos dolbyAtmos)
        {
            throw new NotImplementedException();
        }

        
    }
}
