using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    public class VerificationMethodB : IPaymentVerify
    {
        public bool Verify(PaymentDetails details)
        {
            Console.WriteLine("Verifying Payment Details using VerificationMethodB..");
            return false;
        }
    }
}
