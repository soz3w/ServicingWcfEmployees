using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClientEmployeeService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            //EmployeeService.EmployeeServiceClient client =
            //    new EmployeeService.EmployeeServiceClient();

            //EmployeeService.Employee employee =  client.GetEmployee(Convert.ToInt32(idEmployee.Text)); //change for message contract

            EmployeeService.IEmployeeService client = new EmployeeService.EmployeeServiceClient();
            EmployeeService.EmployeeRequest request = new EmployeeService.EmployeeRequest("SOZLICENSE", Convert.ToInt32(idEmployee.Text));

            EmployeeService.EmployeeInfo employee = client.GetEmployee(request);

            if (employee.typeContract == EmployeeService.EmployeeType.FullTimeEmployee)
            {
                //idAnnualSalary.Text = ((EmployeeService.FullTimeEmployee)employee).AnnualSalary.ToString(); // change for message contract
                idAnnualSalary.Text = employee.AnnualSalary.ToString();
                trAnnualSalary.Visible = true;
                trHourlypay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else
            {
                //idHourlypay.Text = ((EmployeeService.PartTimeEmployee)employee).HourlyPay.ToString();  //change for message contract
                //idHoursWorked.Text = ((EmployeeService.PartTimeEmployee)employee).HoursWorked.ToString();

                idHourlypay.Text = employee.HourlyPay.ToString();
                idHoursWorked.Text = employee.HoursWorked.ToString();
                trAnnualSalary.Visible = false;
                trHourlypay.Visible = true;
                trHoursWorked.Visible = true;

            }

            idTypeContract.SelectedValue = ((int)employee.typeContract).ToString();

            idName.Text = employee.Name;
            idGender.Text = employee.Gender;
            // idDateOfBirth.Text = employee.DateOfBirth.GetValueOrDefault().ToShortDateString();  //change for message contract
            idDateOfBirth.Text = employee.DOB.ToShortDateString();
            lblMessage.Text = "Employee retrieved";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //EmployeeService.EmployeeServiceClient client =
            //    new EmployeeService.EmployeeServiceClient();  //change for message contract
            // EmployeeService.Employee employee = null;

            EmployeeService.IEmployeeService client = new EmployeeService.EmployeeServiceClient();
            EmployeeService.EmployeeInfo employee = new EmployeeService.EmployeeInfo();

            if (idTypeContract.SelectedValue == "-1")
            {
                lblMessage.Text = "Please select a contract type";
            }
            else
            {
                if ((EmployeeService.EmployeeType)Convert.ToInt32(idTypeContract.SelectedValue) == EmployeeService.EmployeeType.FullTimeEmployee)
                {
                    // employee = new EmployeeService.FullTimeEmployee change for message contract
                    //{
                    //    Name = idName.Text,
                    //    Gender = idGender.Text,
                    //    DateOfBirth = Convert.ToDateTime(idDateOfBirth.Text),
                    //    typeContract = EmployeeService.EmployeeType.FullTimeEmployee,
                    //    AnnualSalary = Convert.ToInt32(idAnnualSalary.Text)
                    //};
                    employee.typeContract = EmployeeService.EmployeeType.FullTimeEmployee;
                    employee.AnnualSalary = Convert.ToInt32(idAnnualSalary.Text);
                    //client.SaveEmployee(employee);
                    //lblMessage.Text = "Employee saved";
                }
                else
                {
                    //employee = new EmployeeService.PartTimeEmployee
                    //{
                    //    Name = idName.Text,
                    //    Gender = idGender.Text,
                    //    DateOfBirth = Convert.ToDateTime(idDateOfBirth.Text),
                    //    typeContract = EmployeeService.EmployeeType.PartTimeEmployee,
                    //    HourlyPay = Convert.ToInt32(idHourlypay.Text),
                    //    HoursWorked = Convert.ToInt32(idHoursWorked.Text)
                    //};
                    //client.SaveEmployee(employee);
                    //lblMessage.Text = "Employee saved";

                    employee.typeContract = EmployeeService.EmployeeType.PartTimeEmployee;
                    employee.HourlyPay = Convert.ToInt32(idHourlypay.Text);
                    employee.HoursWorked = Convert.ToInt32(idHoursWorked.Text);
                }

                employee.Name = idName.Text;
                employee.Gender = idGender.Text;
                employee.DOB = Convert.ToDateTime(idDateOfBirth.Text);
                client.SaveEmployee(employee);
                lblMessage.Text = "Employee saved";
            }



        }

        protected void idTypeContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idTypeContract.SelectedValue == "-1")
            {
                trAnnualSalary.Visible = false;
                trHourlypay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else if (idTypeContract.SelectedValue == "1")
            {
                trAnnualSalary.Visible = true;
                trHourlypay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else
            {
                trAnnualSalary.Visible = false;
                trHourlypay.Visible = true;
                trHoursWorked.Visible = true;

            }
        }
    }
}