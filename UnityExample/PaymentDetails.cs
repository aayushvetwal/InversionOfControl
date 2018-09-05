using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    public class PaymentDetails
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string CardNumber { get; set; }
        public string CVV { get; set; }
        public DateTime Expiry { get; set; }
    }
}
