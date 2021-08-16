using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dto
{
    public class MovieDetailDto
    {
        public int Id { get; set; }
        public string Treyler { get; set; }
        public string Country { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Duration { get; set; }
        public string Genre { get; set; }
        public string About { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
