using Entities.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Tariff :IEntity
    {
        public int Id { get; set; }
        public string Image { get; set; }

        
        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
