using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Footer:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
