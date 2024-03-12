using OjoREGED.BLL.DTOs;
using OjoREGED.BLL.Interfaces;
using OjoREGED.BO;
using OjoREGED.DAL;
using OjoREGED.DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace OjoREGED.BLL
{
    public class EmployeeBLL : IemployeeBLL
    {
        private readonly IemployeeDAL _employeeDAL;
        public EmployeeBLL()
        {
            _employeeDAL = new EmployeeDAL();
        }

        public void Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Employee ID is required");
            }

            try
            {
                _employeeDAL.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<employeeDTO> EmployeeLogin(string username, string password)
        {

            List<employeeDTO> Customers = new List<employeeDTO>();

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Username is required");
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password is required");
            }
            try
            {
                var result = _employeeDAL.Login(username, Helper.GetHash(password));
                if (result == null)
                {
                    throw new ArgumentException("Username or Password is wrong");
                }
                foreach (var reads in result)
                {
                    Customers.Add(new employeeDTO
                    {
                        Employee_ID = reads.Employee_ID,
                        First_Name = reads.First_Name,
                        Middle_Name = reads.Middle_Name,
                        Last_Name = reads.Last_Name,
                        Telephone = reads.Telephone,
                        Username = reads.Username,
                        Password = reads.Password
                    });
                }

                return Customers;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }


        }

        public IEnumerable<employeeDTO> GetAllEmployee()
        {
            List<employeeDTO> employeeDTOs = new List<employeeDTO>();
            var EmployeeFromDAL = _employeeDAL.GetAll();
            foreach (var employ in EmployeeFromDAL)
            {
                employeeDTOs.Add(new employeeDTO
                {
                    Employee_ID = employ.Employee_ID,
                    First_Name = employ.First_Name,
                    Middle_Name = employ.Middle_Name,
                    Last_Name = employ.Last_Name,
                    Telephone = employ.Telephone,
                    Username = employ.Username
                    //Password = employ.Password

                });

            }

            return employeeDTOs;
        }

        public IEnumerable<EmployeeScheduleDTO> GetAllEmployeeSchedule()
        {
            List<EmployeeScheduleDTO> employeeDTOsch = new List<EmployeeScheduleDTO>();
            var EmployeeFromDAL = _employeeDAL.GetEmployee_Schedules();
            foreach (var employ in EmployeeFromDAL)
            {
                employeeDTOsch.Add(new EmployeeScheduleDTO
                {
                    Employee_ID = employ.Employee_ID,
                    Employee_Schedule_ID = employ.Employee_Schedule_ID,
                    Date = employ.Date,
                    Status = employ.Status,
                    Order_Scheduled = employ.Order_Scheduled,
                    Max_Order = employ.Max_Order,
                });
            }
            return employeeDTOsch;
        }

        public IEnumerable<employeeDTO> GetDataEmployee()
        {
            List<employeeDTO> Employee = new List<employeeDTO>();
            var result = _employeeDAL.GetAllEmployeeData();

            foreach (var reads in result)
            {
                Employee.Add(new employeeDTO
                {
                    Username = reads.Username,
                    First_Name = reads.First_Name,
                    Middle_Name = reads.Middle_Name,
                    Last_Name = reads.Last_Name,
                    Telephone = reads.Telephone,
                    EmployeeLocations = new Employee_Location()
                    {
                        Employee_Loc_ID = reads.EmployeeLocations.Employee_Loc_ID,
                        City = reads.EmployeeLocations.City,
                        Province = reads.EmployeeLocations.Province,
                        Postal_Code = reads.EmployeeLocations.Postal_Code,
                        Location_Address = reads.EmployeeLocations.Location_Address,
                    },
                    EmployeeSchedules = new Employee_Schedule()
                    {
                        Employee_Schedule_ID = reads.EmployeeSchedules.Employee_Schedule_ID,
                        Date = reads.EmployeeSchedules.Date,
                        Max_Order = reads.EmployeeSchedules.Max_Order,
                        Order_Scheduled = reads.EmployeeSchedules.Order_Scheduled,
                        Status = reads.EmployeeSchedules.Status,
                    }
                });
            }

            return Employee;
        }

        public IEnumerable<employeeDTO> GetEmployeesByID(int id)
        {
            List<employeeDTO> employeeID = new List<employeeDTO>();
            var employeeDAL = _employeeDAL.GetByID(id);
            foreach (var employ in employeeDAL)
            {
                employeeID.Add(new employeeDTO
                {
                    Employee_ID = employ.Employee_ID,
                    First_Name = employ.First_Name,
                    Middle_Name = employ.Middle_Name,
                    Last_Name = employ.Last_Name,
                    Telephone = employ.Telephone,
                    Username = employ.Username,
                    Password = employ.Password

                });
            }
            return employeeID;
        }

        public int Insertemployee(CreateEmployeeDTO employee)
        {
            if (string.IsNullOrEmpty(employee.First_Name))
            {
                throw new ArgumentException("FirstName is required");
            }

            if (string.IsNullOrEmpty(employee.Last_Name))
            {
                throw new ArgumentException("Last Name is required");
            }
            if (string.IsNullOrEmpty(employee.Telephone))
            {
                throw new ArgumentException("telp is required");
            }
            if (string.IsNullOrEmpty(employee.Username))
            {
                throw new ArgumentException("telp is required");
            }
            if (employee.Password != employee.RePassword)
            {
                throw new ArgumentException("Password and Re-Password must be same");
            }

            try
            {
                var employees = new Employee
                {
                    Employee_ID = employee.Employee_ID,
                    First_Name = employee.First_Name,
                    Middle_Name = employee.Middle_Name,
                    Last_Name = employee.Last_Name,
                    Telephone = employee.Telephone,
                    Username = employee.Username,
                    Password = Helper.GetHash(employee.Password)
                };
                int result = _employeeDAL.AddUser(employees);
                return result;
            }
            catch (System.Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }


        }

        public void Update(employeeDTO employee)
        {

            try
            {
                var employees = new Employee
                {
                    Employee_ID = employee.Employee_ID,
                    First_Name = employee.First_Name,
                    Middle_Name = employee.Middle_Name,
                    Last_Name = employee.Last_Name,
                    Telephone = employee.Telephone,
                };

                if (string.IsNullOrEmpty(employee.Middle_Name))
                {
                    employees.Middle_Name = null;
                }
                _employeeDAL.Update(employees);


            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
