using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    public class PaymentServiceB : IPaymentService
    {
        IPaymentVerify paymentVerify;

        public PaymentServiceB(IPaymentVerify paymentVerify)
        {
            this.paymentVerify = paymentVerify;
        }

        public PaymentServiceB()
        {
            paymentVerify = new VerificationMethodB();
        }

        public bool Pay(PaymentDetails details)
        {
            Console.WriteLine("Paying using PaymentServiceB..");
            if (Verify(details))
            {
                //Call Payment Service
                //if successful return true;
                return false;
            }
            return false;
        }

        public bool Verify(PaymentDetails details)
        {
            return paymentVerify.Verify(details);
        }
    }
}
