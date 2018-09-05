using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stage5
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }
}
