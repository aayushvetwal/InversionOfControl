using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stage2
{
    public class CustomerBusinessLogic
    {
        public CustomerBusinessLogic()
        {
        }

        public string GetCustomerName(int id)
        {
            DataAccess _dataAccess = DataAccessFactory.GetDataAccessObj();

            return _dataAccess.GetCustomerName(id);
        }

    }
}

/*
 *CustomerBusinessLogic class uses DataAccessFactory.GetCustomerDataAccessObj() method to get an object 
 *of DataAccess class instead of creating it using new keyword. Thus, we have inverted the control of creating an object 
 *of dependent class from CustomerBusinessLogic class to DataAccessFactory class. This is a simple implementation of IoC 
 *and the first step towards achieving fully loose coupled design.
 */

/*
 * In the above example, we implemented factory pattern to achieve IoC. But, CustomerBusinessLogic class uses concrete 
 * DataAccess class. So still it is tightly coupled even though we have inverted the dependent object creation to the factory 
 * class. 
 */
