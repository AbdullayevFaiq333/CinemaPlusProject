using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Seat:IEntity
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public int RowId { get; set; }
        public Row Row { get; set; }
    }
}
