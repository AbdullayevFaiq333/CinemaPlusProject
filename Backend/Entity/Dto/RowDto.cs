using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dto
{
    public class RowDto
    {
        public int Id { get; set; }
        public int NumberRow { get; set; }
        public int HallId { get; set; }

        public List<SeatDto> Seats { get; set; }
    }
}
