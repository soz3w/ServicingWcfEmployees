using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _05EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {

        //public Employee GetEmployee(int id)  //change for message contract
        public EmployeeInfo GetEmployee(EmployeeRequest request)  //change for message contract
        {
            //Context db = new Context();
            //Employee employee = (from e in db.tblEmployees
            //                     where e.Id == id
            //                     select e).SingleOrDefault();

            //return employee;

            Employee employee = null;
            string cs = ConfigurationManager.ConnectionStrings["Context"].ConnectionString;
            using(SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";

               // parameterId.Value = id; //change for message contract
                parameterId.Value = request.EmployeeId;

                cmd.Parameters.Add(parameterId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    if((EmployeeType)reader["typeContract"]==EmployeeType.FullTimeEmployee)
                    {
                        employee = new FullTimeEmployee()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Gender = reader["Gender"].ToString(),
                            Name = reader["Name"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            typeContract=EmployeeType.FullTimeEmployee,
                            AnnualSalary =Convert.ToInt32(reader["AnnualSalary"]),

                        };
                    }
                    else
                    {
                        employee = new PartTimeEmployee()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Gender = reader["Gender"].ToString(),
                            Name = reader["Name"].ToString(),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            typeContract = EmployeeType.PartTimeEmployee,
                            HourlyPay = Convert.ToInt32(reader["HourlyPay"]),
                            HoursWorked = Convert.ToInt32(reader["HoursWorked"])
                        };

                    }
                   
                }

                
            }

            //return employee;  //change for the message contract

            return new EmployeeInfo(employee);

            
        }

        // public void SaveEmployee(Employee employee) // change for message contract
        public void SaveEmployee(EmployeeInfo employee)
        {
            string cs = ConfigurationManager.ConnectionStrings["Context"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spSaveEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterName = new SqlParameter
                {
                    ParameterName = "@Name",
                    Value = employee.Name
                };
                
                cmd.Parameters.Add(parameterName);

                SqlParameter parameterGender = new SqlParameter();
                parameterGender.ParameterName = "@Gender";
                parameterGender.Value = employee.Gender;
                cmd.Parameters.Add(parameterGender);
               

                SqlParameter parameterDateOfBirth = new SqlParameter();
                parameterDateOfBirth.ParameterName = "@DateOfBirth";
                //parameterDateOfBirth.Value = employee.DateOfBirth; //change for message contract
                parameterDateOfBirth.Value = employee.DOB;
                cmd.Parameters.Add(parameterDateOfBirth);

                SqlParameter parametertypeContract = new SqlParameter
                {
                    ParameterName = "@typeContract",
                    Value = employee.typeContract
                };
                cmd.Parameters.Add(parametertypeContract);
                //if (employee.GetType() == typeof(FullTimeEmployee))  //change for message contract
                if (employee.typeContract == EmployeeType.FullTimeEmployee)
                {
                    SqlParameter parameterAnnualSalary = new SqlParameter
                    {
                        ParameterName = "@AnnualSalary",
                        //Value = ((FullTimeEmployee)employee).AnnualSalary //change for message contract
                        Value = employee.AnnualSalary 
                    };
                    cmd.Parameters.Add(parameterAnnualSalary);

                }
                else
                {
                    SqlParameter parameterHourlyPay = new SqlParameter
                    {
                        ParameterName = "@HourlyPay",
                        // Value = ((PartTimeEmployee)employee).HourlyPay //change for message contract
                        Value = employee.HourlyPay
                    };
                    cmd.Parameters.Add(parameterHourlyPay);

                    SqlParameter parameterHoursWorked = new SqlParameter
                    {
                        ParameterName = "@HoursWorked",
                        // Value = ((PartTimeEmployee)employee).HoursWorked //change for message contract
                        Value = employee.HoursWorked
                    };
                    cmd.Parameters.Add(parameterHoursWorked);

                }

                con.Open();
                cmd.ExecuteNonQuery();

               
            }
        }
    }
}
