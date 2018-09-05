using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace UnityExample
{
    public class OracleDataAccess : ICustomerDataAccess
    {
        public OracleDataAccess()
        {
            //Connect to Database
        }

        public string GetCustomerName(int id)
        {
            //Get Customer Name from Database
            Console.WriteLine("returning Customer Name using OracleDataAccess..");
            return String.Empty;
        }

        public DataSet GetLatestTransactions(int id)
        {
            //Get Transactions from Database
            Console.WriteLine("returning Customer Transactions using OracleDataAccess..");
            return new DataSet();
        }
    }
}
