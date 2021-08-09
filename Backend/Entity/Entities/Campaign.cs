using Core.Entities;

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public CampaignDetail CampaignDetail { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
