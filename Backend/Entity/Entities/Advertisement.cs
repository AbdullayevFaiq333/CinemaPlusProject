
using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Advertisement:IEntity
    {
        public int Id { get; set; }
        public string Background { get; set; }
        public string Image { get; set; }
        public bool IsDeleted { get; set; }
        [NotMapped]
        public IFormFile BackgroundPhoto { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
