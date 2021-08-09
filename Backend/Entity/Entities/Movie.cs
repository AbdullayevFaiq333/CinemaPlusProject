using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Movie:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public MovieDetail MovieDetail { get; set; }
        public ICollection<MovieFormat> MovieFormats { get; set; }
        public ICollection<Session> Sessions { get; set; }
    }
}
