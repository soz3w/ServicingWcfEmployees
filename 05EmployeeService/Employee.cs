namespace _05EmployeeService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    using System.ServiceModel; // for message contract ------------------

    [MessageContract(IsWrapped=true,WrapperName="EmployeeRequestObject", WrapperNamespace="http://mycompany.com/Employee")]
    public class EmployeeRequest
    {
        [MessageHeader(Namespace = "http://mycompany.com/Employee")]
        public string LicenseKey { get; set; }

        [MessageBodyMember(Namespace = "http://mycompany.com/Employee")]
        public int EmployeeId { get; set; }
    }

    [MessageContract(IsWrapped = true, WrapperName = "EmployeeInfoObject", WrapperNamespace = "http://mycompany.com/Employee")]
    public class EmployeeInfo
    {
        public EmployeeInfo()
        {

        }
        public EmployeeInfo(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.Gender = employee.Gender;
            this.DOB = employee.DateOfBirth.GetValueOrDefault();
            this.typeContract = employee.typeContract;
            if (this.typeContract== EmployeeType.FullTimeEmployee)
            {
                this.AnnualSalary = ((FullTimeEmployee)employee).AnnualSalary;
            }
            else
            {
                this.HourlyPay = ((PartTimeEmployee)employee).HourlyPay;
                this.HoursWorked = ((PartTimeEmployee)employee).HoursWorked;
            }
        }
        [MessageBodyMember(Order = 1, Namespace = "http://mycompany.com/Employee")]
        public int Id { get; set; }
        [MessageBodyMember(Order = 2, Namespace = "http://mycompany.com/Employee")]
        public string Name { get; set; }
        [MessageBodyMember(Order = 3, Namespace = "http://mycompany.com/Employee")]
        public string Gender { get; set; }

        [MessageBodyMember(Order = 4, Namespace = "http://mycompany.com/Employee")]
        public DateTime DOB { get; set; }

        [MessageBodyMember(Order = 5, Namespace = "http://mycompany.com/Employee")]
        public EmployeeType typeContract { get; set; }

        [MessageBodyMember(Order = 6, Namespace = "http://mycompany.com/Employee")]
        public int AnnualSalary { get; set; }

        [MessageBodyMember(Order = 7, Namespace = "http://mycompany.com/Employee")]
        public int HourlyPay { get; set; }

        [MessageBodyMember(Order = 8, Namespace = "http://mycompany.com/Employee")]
        public int HoursWorked { get; set; }
    }
    //-------------------------------------------------------


    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
    [DataContract]

    public partial class Employee
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Name { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Gender { get; set; }

        [DataMember]
        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [DataMember]
        public EmployeeType typeContract { get; set; }
        
    }
    public enum EmployeeType
    {
        FullTimeEmployee = 1,
        PartTimeEmployee = 2
    }
}
