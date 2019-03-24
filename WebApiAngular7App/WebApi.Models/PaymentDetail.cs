using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Models
{
    public class PaymentDetail
    {
        public int ID { get; set; }
        public string CardOwnerName { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string CVV { get; set; }


    }
}
