using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Branch:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public int PhotosId { get; set; }
        public Photos Photos { get; set; }

        public Tariff Tariff { get; set; }
        public Contact Contact { get; set; }
    }
}


