using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stage4
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }
}
