using Entities.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class AboutUsBottomPart:IEntity
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        
        [NotMapped]
        public IFormFile Photo { get; set; }


    }
}
