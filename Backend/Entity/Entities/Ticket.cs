using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Ticket:IEntity
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int SessionId { get; set; }
        public Session Session { get; set; }
    }
}
