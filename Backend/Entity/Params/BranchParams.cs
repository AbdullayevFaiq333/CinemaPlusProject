using Entities.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity.Params
{
    public class BranchParams
    {
        public string Name { get; set; } 
        public string Description { get; set; }
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }




        //Contact
        public string OurAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string MediaSalesDepartment { get; set; }
        public string WorkingHours { get; set; }
        public string Map { get; set; }
        public int BranchId { get; set; }
        public int ContactId { get; set; }



        //Tariff
        public string TariffImage { get; set; }
        public int TariffId { get; set; }

        [NotMapped]
        public IFormFile TariffPhoto { get; set; }


        //Photos
        public string PhotosImage { get; set; }
        public int PhotosId{ get; set; }

        [NotMapped]
        public IFormFile PhotosPhoto { get; set; }


    }
}
