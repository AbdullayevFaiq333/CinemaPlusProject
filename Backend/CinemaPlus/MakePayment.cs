using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaPlus
{
    public class MakePayment
    {
        public static async Task<dynamic> PayAsync(string CardNumber,int Month,int Year,string Cvc,int Value)
        {
            try
            {
                StripeConfiguration.ApiKey = "sk_test_51JSg7WEzYHUBwYrgcbylMrCexsqq1efF2ixf2uJsedfnVFZmym9CP8roJswp5nUdW3omAT5nwEPUVuVNoo2G7FjX00lzTquaC1";
                var optionstoken = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = CardNumber,
                        ExpMonth = Month,
                        ExpYear = Year,
                        Cvc = Cvc
                    }

                };

                var servicetoken = new TokenService();
                Token stripetoken = await servicetoken.CreateAsync(optionstoken);

                var options = new ChargeCreateOptions
                {
                    Amount = Value,
                    Currency = "usd",
                    Description = "test",
                    Source = stripetoken.Id
                };

                var service = new ChargeService();
                Charge charge = await service.CreateAsync(options);

                if (charge.Paid)
                {
                    return "Success";
                }
                else
                {
                    return "failed";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
    }
}
