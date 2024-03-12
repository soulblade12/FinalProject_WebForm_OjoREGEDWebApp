using OjoREGED.BO;
using System.Collections.Generic;

namespace OjoREGED.DAL.Interfaces
{
    public interface IemployeeDAL : Icrud<Employee>
    {
        int AddUser(Employee employee);
        IEnumerable<Employee> GetByID(int id);
        IEnumerable<Employee_Schedule> GetEmployee_Schedules();
        IEnumerable<Employee> GetAllEmployeeData();
        IEnumerable<Employee> Login(string Username, string password);
    }
}
