using OjoREGED.BLL.DTOs;
using System.Collections.Generic;

namespace OjoREGED.BLL.Interfaces
{
    public interface IemployeeBLL
    {
        IEnumerable<employeeDTO> EmployeeLogin(string username, string password);
        int Insertemployee(CreateEmployeeDTO employee);
        IEnumerable<employeeDTO> GetAllEmployee();
        IEnumerable<EmployeeScheduleDTO> GetAllEmployeeSchedule();
        IEnumerable<employeeDTO> GetEmployeesByID(int id);
        void Update(employeeDTO employee);
        IEnumerable<employeeDTO> GetDataEmployee();

        void Delete(int id);
    }
}
