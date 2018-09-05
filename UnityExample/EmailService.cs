using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace UnityExample
{
    public class EmailService : IEmailService
    {
        ICustomerDataAccess _dataAccess;


        public EmailService(ICustomerDataAccess dataAccess)
        {
            _dataAccess = dataAccess;   
        }

        public EmailService()
        {
            _dataAccess = new SqlDataAccess();
        }

        public void EmailTransactions(int id)
        {
            DataSet dsTransactions = _dataAccess.GetLatestTransactions(id);
            //Email Transactions
            Console.WriteLine("Emailing Transactions...");
        }

    }
}
