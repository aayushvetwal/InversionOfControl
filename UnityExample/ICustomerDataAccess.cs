using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace UnityExample
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
        DataSet GetLatestTransactions(int id);
    }
}
