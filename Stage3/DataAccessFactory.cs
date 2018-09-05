using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stage3
{
    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }
}
