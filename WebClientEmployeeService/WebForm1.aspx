<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebClientEmployeeService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>Id:</td>
                <td>
                    <asp:TextBox ID="idEmployee" runat="server"></asp:TextBox></td>

            </tr>
            <tr>
                <td>Name:</td>
                <td>
                    <asp:TextBox ID="idName" runat="server"></asp:TextBox></td>

            </tr>
            <tr>
                <td>Gender:</td>
                <td>
                    <asp:TextBox ID="idGender" runat="server"></asp:TextBox></td>

            </tr>
            <tr>
                <td>Date of birth:</td>
                <td>
                    <asp:TextBox ID="idDateOfBirth" runat="server"></asp:TextBox></td>

            </tr>
            <tr>
                <td>Employee Type:</td>
                <td>
                    <asp:DropDownList ID="idTypeContract" runat="server" AutoPostBack="True" Height="16px" Width="132px" OnSelectedIndexChanged="idTypeContract_SelectedIndexChanged">
                        <asp:ListItem Text="Select Employee Type" Value="-1" />
                        <asp:ListItem Text="Full Time Employee" Value="1" />
                        <asp:ListItem Text="Part Time Employee" Value="2" />
                    </asp:DropDownList></td>

            </tr>
            <tr id ="trAnnualSalary" runat="server" visible="false">
                <td>Annual Salary:</td>
                <td>
                    <asp:TextBox ID="idAnnualSalary" runat="server"></asp:TextBox></td>

            </tr>
            <tr id ="trHourlypay" runat="server" visible="false">
                <td>Hourly Pay:</td>
                <td>
                    <asp:TextBox ID="idHourlypay" runat="server"></asp:TextBox></td>

            </tr>
            <tr id ="trHoursWorked" runat="server" visible="false">
                <td>Hours Worked:</td>
                <td>
                    <asp:TextBox ID="idHoursWorked" runat="server"></asp:TextBox></td>

            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Label ID="lblMessage" runat="server" Font-Italic="True" Font-Size="Smaller" ForeColor="#009933"></asp:Label>

                </td>

            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnGet" runat="server" Text="Get Employee" OnClick="btnGet_Click" /></td>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Save Employee" OnClick="btnSave_Click" /></td>
            </tr>
        </table>

    </form>
</body>
</html>
