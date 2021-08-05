using Entities.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Format:IEntity
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public ICollection<MovieFormat> MovieFormats { get; set; }

    }
}
