using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class CampaignDetail:IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }

        [ForeignKey("Campaign")]
        public int CampaignId { get; set; }
        public Campaign Campaign { get; set; }
    }
}
