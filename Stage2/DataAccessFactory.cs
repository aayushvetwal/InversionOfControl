using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stage2
{
    public class DataAccessFactory
    {
        public static DataAccess GetDataAccessObj()
        {
            return new DataAccess();
        }

    }
}
