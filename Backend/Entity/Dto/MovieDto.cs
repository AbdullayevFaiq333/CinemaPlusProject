using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dto
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
