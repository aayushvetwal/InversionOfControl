using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnityExample
{
    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _dataAccess;
        IPaymentService _paymentService;
        IEmailService _emailService;
        
        public CustomerBusinessLogic(ICustomerDataAccess dataAccess, IPaymentService paymentService, IEmailService emailService)
        {
            _dataAccess = dataAccess;
            _paymentService = paymentService;
            _emailService = emailService;
        }

        public CustomerBusinessLogic()
        {
            _dataAccess = new SqlDataAccess();
        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }

        public bool Pay(PaymentDetails details)
        {
            return _paymentService.Pay(details);
        }

        public void EmailTransactions(int id)
        {
            _emailService.EmailTransactions(id);
        }
    }
}
