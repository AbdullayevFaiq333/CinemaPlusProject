using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaPlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayController : ControllerBase
    {
        [HttpPost]

        public async Task<dynamic> Pay(Entity.Dto.PaymentDto pm)
        {
            return await MakePayment.PayAsync(pm.CartNumber, pm.Month, pm.Year, pm.Cvc, pm.Value);
        }
    }
}
