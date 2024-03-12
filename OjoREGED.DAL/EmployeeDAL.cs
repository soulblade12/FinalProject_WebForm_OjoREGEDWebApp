using OjoREGED.BO;
using OjoREGED.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static Dapper.SqlMapper;

namespace OjoREGED.DAL
{
    public class EmployeeDAL : IemployeeDAL
    {

        private string GetConnString()
        {
            return ConfigurationManager.ConnectionStrings["LatihanDbConnectionString"].ConnectionString;
        }
        public int AddUser(Employee employee)
        {
            using (SqlConnection conn = new SqlConnection(GetConnString()))
            {
                var strsp = "dbo.InsertEmployee";
                var param = new
                {
                    FirstName = employee.First_Name,
                    MiddleName = employee.Middle_Name,
                    LastName = employee.Last_Name,
                    Telephone = employee.Telephone,
                    Username = employee.Username,
                    Password = employee.Password
                };
                try
                {
                    int result = Convert.ToInt32(conn.Execute(strsp, param, commandType: System.Data.CommandType.StoredProcedure));
                    if (result != 1)
                    {
                        throw new ArgumentException("Insert data failed..");
                    }
                    return result;
                }
                catch (SqlException sqlEx)
                {
                    throw new ArgumentException($"{sqlEx.InnerException.Message} - {sqlEx.Number}");
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(ex.Message);
                }


            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(GetConnString()))
            {
                var strSP = @"dbo.DeleteEmployee";
                var param = new { ID = id };

                try
                {
                    int result = conn.Execute(strSP, param);
                    if (result != 1)
                    {
                        throw new Exception("Data tidak berhasil dihapus");
                    }
                }
                catch (SqlException sqlEx)
                {
                    throw new ArgumentException($"{sqlEx.InnerException.Message} - {sqlEx.Number}");
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Kesalahan: " + ex.Message);
                }


            }
        }

        public IEnumerable<Employee> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(GetConnString()))
            {
                var strsql = @"SELECT Employee_ID,First_Name,Middle_Name,Last_Name,Telephone,Username FROM Employee";
                //var result = conn.Query<Employee>(strsql);
                //foreach (employee emp in result)
                //    throw new argumentexception(convert.tostring(emp.empid));

                //return result;
                List<Employee> Employee = new List<Employee>();
                SqlCommand cmd = new SqlCommand(strsql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var employee = new Employee()
                        {
                            Employee_ID = Convert.ToInt32(dr["Employee_ID"]),
                            First_Name = dr["First_Name"].ToString(),
                            Middle_Name = dr["Middle_Name"].ToString(),
                            Last_Name = dr["Last_Name"].ToString(),
                            Telephone = dr["Telephone"].ToString(),
                            Username = dr["Username"].ToString()
                        };
                        Employee.Add(employee);
                    }
                }
                return Employee;
            }




        }



        public Employee GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Employee entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Employee entity)
        {
            using (SqlConnection conn = new SqlConnection(GetConnString()))
            {
                var strSp = @"UPDATE Employee 
                         SET First_Name = @First_Name, 
                             Middle_Name = @Middle_Name, 
                             Last_Name = @Last_Name, 
                             Telephone = @Telephone 
                         WHERE Employee_ID = @Employee_ID";

                var param = new
                {
                    Employee_ID = entity.Employee_ID,
                    First_Name = entity.First_Name,
                    Middle_Name = entity.Middle_Name,
                    Last_Name = entity.Last_Name,
                    Telephone = entity.Telephone,


                };
                try
                {
                    int result = conn.Execute(strSp, param, commandType: System.Data.CommandType.Text);
                    if (result != 1)
                    {
                        throw new ArgumentException("Update data failed..");
                    }
                    //return result;

                }
                catch (SqlException sqlEx)
                {
                    throw new ArgumentException($"{sqlEx.InnerException.Message} - {sqlEx.Number}");
                }
                catch (Exception ex)
                {
                    throw new ArgumentException(ex.Message);
                }


            }
        }





        public IEnumerable<Employee> GetByID(int id)
        {
            using (SqlConnection conn = new SqlConnection(GetConnString()))
            {
                var strSql = @"dbo.ReadEmployee";
                //var param = new { EmployeeID = id };
                //var result = conn.Query<Employee>(strSql, param, commandType: System.Data.CommandType.StoredProcedure);
                //return result;

                List<Employee> Employee = new List<Employee>();
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeID", id);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var employee = new Employee()
                        {
                            Employee_ID = Convert.ToInt32(dr["Employee_ID"]),
                            First_Name = dr["First_Name"].ToString(),
                            Middle_Name = dr["Middle_Name"].ToString(),
                            Last_Name = dr["Last_Name"].ToString(),
                            Telephone = dr["Telephone"].ToString(),
                            Username = dr["Username"].ToString(),
                            Password = dr["Password"].ToString(),
                        };
                        Employee.Add(employee);
                    }
                }
                return Employee;
            }
        }

        public IEnumerable<Employee_Schedule> GetEmployee_Schedules()
        {
            using (SqlConnection conn = new SqlConnection(GetConnString()))
            {
                var strSql = @"select * from Employee_Schedule";

                List<Employee_Schedule> EmployeeSchedule = new List<Employee_Schedule>();
                SqlCommand cmd = new SqlCommand(strSql, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var employee = new Employee_Schedule()
                        {
                            Employee_ID = Convert.ToInt32(dr["Employee_ID"]),
                            Employee_Schedule_ID = Convert.ToInt32(dr["Employee_Schedule_ID"]),
                            Date = Convert.ToDateTime(dr["Date"]),
                            Max_Order = Convert.ToInt32(dr["Max_Order"]),
                            Order_Scheduled = Convert.ToInt32(dr["Order_Scheduled"]),
                            Status = dr["Status"].ToString(),
                        };
                        EmployeeSchedule.Add(employee);
                    }
                }
                return EmployeeSchedule;
            }
        }

        public IEnumerable<Employee> GetAllEmployeeData()
        {
            using (SqlConnection conn = new SqlConnection(GetConnString()))
            {
                var strSql = @"SELECT 
    emp.Employee_ID , 
    emp.First_Name, 
    emp.Middle_Name, 
    emp.Last_Name, 
    emp.Telephone, 
    emp_sched.Employee_Schedule_ID, 
    emp_sched.Status, 
    emp_sched.Date, 
    emp_sched.Max_Order, 
    emp_sched.Order_Scheduled, 
    emp_loc.Employee_Loc_ID, 
    emp_loc.Province, 
    emp_loc.City, 
    emp_loc.Location_Address, 
    emp_loc.Postal_Code
FROM     
    dbo.Employee AS emp 
    LEFT OUTER JOIN dbo.Employee_Schedule AS emp_sched ON emp.Employee_ID = emp_sched.Employee_ID 
    INNER JOIN dbo.Employee_Location AS emp_loc ON emp.Employee_ID = emp_loc.Employee_ID";

                List<Employee> Employee = new List<Employee>();
                SqlCommand cmd = new SqlCommand(strSql, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var employes = new Employee()
                        {
                            Employee_ID = Convert.ToInt32(dr["Employee_ID"]),
                            First_Name = dr["First_Name"].ToString(),
                            Middle_Name = dr["Middle_Name"].ToString(),
                            Last_Name = dr["Last_Name"].ToString(),
                            Telephone = dr["Telephone"].ToString(),
                            EmployeeLocations = new Employee_Location()
                            {
                                Employee_Loc_ID = Convert.ToInt32(dr["Employee_Loc_ID"]),
                                City = dr["City"].ToString(),
                                Province = dr["Province"].ToString(),
                                Postal_Code = dr["Postal_Code"].ToString(),
                                Location_Address = dr["Postal_Code"].ToString(),
                            },
                            EmployeeSchedules = new Employee_Schedule()
                            {
                                Employee_Schedule_ID = Convert.ToInt32(dr["Employee_Schedule_ID"]),
                                Date = Convert.ToDateTime(dr["Date"]),
                                Max_Order = Convert.ToInt32(dr["Max_Order"]),
                                Order_Scheduled = Convert.ToInt32(dr["Order_Scheduled"]),
                                Status = dr["Status"].ToString(),
                            }

                        };

                        Employee.Add(employes);
                    }
                }
                return Employee;
            }
        }

        public IEnumerable<Employee> Login(string Username, string password)
        {

            using (SqlConnection conn = new SqlConnection(GetConnString()))
            {
                var strSql = @"SELECT * FROM Employee WHERE Username = @Username and Password = @Password";

                List<Employee> Employes = new List<Employee>();
                SqlCommand cmd = new SqlCommand(strSql, conn);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", password);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        var employee = new Employee()
                        {
                            Employee_ID = Convert.ToInt32(dr["Employee_ID"]),
                            First_Name = dr["First_Name"].ToString(),
                            Middle_Name = dr["Middle_Name"].ToString(),
                            Last_Name = dr["Last_Name"].ToString(),
                            Telephone = dr["Telephone"].ToString(),
                            Username = dr["Username"].ToString(),
                            Password = dr["Password"].ToString(),
                        };
                        Employes.Add(employee);
                    }
                }
                return Employes;
            }

        }
    }
}





