using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractRealExample.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
