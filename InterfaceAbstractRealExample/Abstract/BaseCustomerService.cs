
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractRealExample.Abstract
{
    public abstract class BaseCustomerService : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("saved to db : "+customer.FirstName);
        }
    }
}
