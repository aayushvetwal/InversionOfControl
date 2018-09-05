using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stage3
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }
}
