using Entities.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class CinemaClub:IEntity
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string FirstCartTitle { get; set; }
        public string FirstCartImage { get; set; }
        public string SecondCartTitle { get; set; }
        public string SecondCartImage { get; set; }
        public string Termins { get; set; }
        public string Conditions { get; set; }
        public bool IsDeleted { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile FirstCartPhoto { get; set; }
        [NotMapped]
        public IFormFile SecondCartPhoto { get; set; }

    }
}
