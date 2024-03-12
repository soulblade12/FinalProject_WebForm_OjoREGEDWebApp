using OjoREGED.BLL.DTOs;
using System.Collections.Generic;

namespace OjoREGED.BLL.Interfaces
{
    internal interface ICustomerBLL
    {
        int InsertCustomer(CustomerCreateDTO Customer);
        int AddAddress(AddressesDTO addresscustomer);
        IEnumerable<CustomerLoginDTO> CustomerLogin(string username, string password);
        IEnumerable<CustomerDTO> CustomerGetByID(int id);
        IEnumerable<OrderPlacedDTO> custGetOrderByCustomeromergetbyid(int id);

        void AddBooking(InsertBookingSP insertbook);


    }
}
