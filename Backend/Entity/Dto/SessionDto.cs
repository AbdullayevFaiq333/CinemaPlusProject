using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dto
{
    public class SessionDto
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int MovieId { get; set; }
        public int HallId { get; set; }
        public int BranchId { get; set; }

    }
}
