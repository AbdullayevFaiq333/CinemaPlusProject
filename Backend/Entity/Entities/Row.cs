using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Row:IEntity
    {
        public int Id { get; set; }
        public int NumberRow { get; set; }
        public int HallId { get; set; }
        public Hall Hall { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
