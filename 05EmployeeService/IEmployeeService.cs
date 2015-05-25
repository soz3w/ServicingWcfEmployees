using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _05EmployeeService
{
    
    //[ServiceContract]
    //public interface IEmployeeService
    //{
    //    [OperationContract]
    //    Employee GetEmployee(int id);

    //    [OperationContract]
    //    void SaveEmployee(Employee employee);
    //}

    //change for Message contract
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        EmployeeInfo GetEmployee(EmployeeRequest request);

        [OperationContract]
        void SaveEmployee(EmployeeInfo employee);
    }
}
