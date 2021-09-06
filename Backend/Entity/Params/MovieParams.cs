using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity.Params
{
   public class MovieParams
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
        public int LanguageId { get; set; }

        //Details
        public string Treyler { get; set; }
        public string Country { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Duration { get; set; }
        public string Genre { get; set; }
        public string About { get; set; }
        public int MovieId { get; set; }
        public string LanguageName { get; set; }
        public int MovieDetailId{ get; set; }
    }
}
