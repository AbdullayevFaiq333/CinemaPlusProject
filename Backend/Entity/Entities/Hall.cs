using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Hall:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public ICollection<Session> Sessions { get; set; }
        public ICollection<Row> Rows { get; set; }
    }
}
