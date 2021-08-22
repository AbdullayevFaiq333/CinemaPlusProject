using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dto
{
    public class TicketDto
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int SessionId { get; set; }
    }
}
