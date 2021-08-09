using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
    public class NewsDto
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Decription { get; set; }
        public DateTime DateTime { get; set; }
    }
}
