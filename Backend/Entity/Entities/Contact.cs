using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Entities.Models
{
    public class Contact:IEntity
    {
        public int Id { get; set; }
        public string OurAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string MediaSalesDepartment { get; set; }
        public string WorkingHours { get; set; }
        public string Map { get; set; }

        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        public Branch Branch { get; set; }

    }
}
