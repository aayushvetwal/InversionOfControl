using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    public class PaymentServiceA  : IPaymentService
    {
        IPaymentVerify paymentVerify;

        public PaymentServiceA(IPaymentVerify paymentVerify)
        {
            this.paymentVerify = paymentVerify;
        }

        public PaymentServiceA()
        {
            paymentVerify = new VerificationMethodA();
        }

        public bool Pay(PaymentDetails details)
        {
            Console.WriteLine("Paying using PaymentServiceA..");
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
