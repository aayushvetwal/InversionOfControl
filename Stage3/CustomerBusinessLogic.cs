using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stage3
{
    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _custDataAccess;

        public CustomerBusinessLogic()
        {
            _custDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
            return _custDataAccess.GetCustomerName(id);
        }

    }
}

/* 
 * we have implemented DIP in our example where high-level module (CustomerBusinessLogic) and low-level module (CustomerDataAccess)
 * are depends on abstraction (ICustomerDataAccess). Also, abstraction (ICustomerDataAccess) does not depends on 
 * details(CustomerDataAccess) but details depend on abstraction. 
 */

/*
 * Advantages of implementing DIP in the above example is that CustomerBusinessLogic and CustomerDataAccess classes are loosely 
 * coupled classes because CustomerBusinessLogic does not depend on concrete DataAccess class, instead it includes reference of 
 * ICustomerDataAccess interface. So now, we can easily use another class which implements ICustomerDataAccess with different 
 * implementation. 
*/

/*
 * Still, we have not achieved fully loosely coupled classes because CustomerBusinessLogic class includes Factory class to get 
 * the reference of ICustomerDataAccess. This is where Dependency Injection pattern helps us.
*/