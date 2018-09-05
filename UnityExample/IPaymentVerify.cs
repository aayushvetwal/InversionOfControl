using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    public interface IPaymentVerify
    {
        bool Verify(PaymentDetails details);
    }
}
