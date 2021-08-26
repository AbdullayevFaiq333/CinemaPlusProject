using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dto
{
    public class PaymentDto
    {
        public string CartNumber { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Cvc { get; set; }
        public int Value { get; set; }
    }
}
