using InterfaceAbstractRealExample.Abstract;
using InterfaceAbstractRealExample.Adapters;
using InterfaceAbstractRealExample.Concrete;
using System;

namespace InterfaceAbstractRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerService manager = new StarbucksCustomerManager(new MernisServiceAdepter());
            manager.Save(new Customer { DateOfBirth = new DateTime(2000, 12, 12), FirstName = "Merve", LastName = "Keçeli", NationalityId = "31210254356" });
            Console.ReadLine();
        }
    }
}
