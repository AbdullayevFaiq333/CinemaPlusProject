using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class DolbyAtmos:IEntity
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string FirstTitle { get; set; }
        public string FirstDescription { get; set; }
        public string YoutubeURL { get; set; }
        public string SecondTitle { get; set; }
        public string SecondDescription { get; set; }

        public Language Language { get; set; }
        public int LanguageId { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
