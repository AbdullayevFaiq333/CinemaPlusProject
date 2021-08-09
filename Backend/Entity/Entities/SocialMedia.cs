using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class SocialMedia:IEntity
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public bool IsDeleted { get; set; }
        
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
