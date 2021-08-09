﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ITicketService
    {
        Task<Ticket> GetTicketWithIdAsync(int id);
        Task<List<Ticket>> GetAllTicketAsync();
        Task<bool> AddTicketAsync(Ticket ticket);
        Task<bool> UpdateTicketAsync(Ticket ticket);
        Task<bool> DeleteTicketAsync(int id);
    }
}
