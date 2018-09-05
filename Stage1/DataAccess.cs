using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stage1
{
    public class DataAccess
    {
        public DataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            return String.Format("Stage {0}: Dummy Customer Name", id);
        }

    }
}
