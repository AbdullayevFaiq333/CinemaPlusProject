using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Photos:IEntity
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public ICollection<Branch> Branches { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
