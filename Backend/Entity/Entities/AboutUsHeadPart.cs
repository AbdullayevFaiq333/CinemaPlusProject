using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class AboutUsHeadPart:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description  { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
