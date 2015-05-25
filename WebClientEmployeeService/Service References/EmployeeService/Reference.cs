﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClientEmployeeService.EmployeeService {
    using System.Runtime.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeType", Namespace="http://schemas.datacontract.org/2004/07/_05EmployeeService")]
    public enum EmployeeType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FullTimeEmployee = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PartTimeEmployee = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeResponse")]
        WebClientEmployeeService.EmployeeService.EmployeeInfo GetEmployee(WebClientEmployeeService.EmployeeService.EmployeeRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployee", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeResponse")]
        System.Threading.Tasks.Task<WebClientEmployeeService.EmployeeService.EmployeeInfo> GetEmployeeAsync(WebClientEmployeeService.EmployeeService.EmployeeRequest request);
        
        // CODEGEN: Generating message contract since the operation SaveEmployee is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/SaveEmployee", ReplyAction="http://tempuri.org/IEmployeeService/SaveEmployeeResponse")]
        WebClientEmployeeService.EmployeeService.SaveEmployeeResponse SaveEmployee(WebClientEmployeeService.EmployeeService.EmployeeInfo request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/SaveEmployee", ReplyAction="http://tempuri.org/IEmployeeService/SaveEmployeeResponse")]
        System.Threading.Tasks.Task<WebClientEmployeeService.EmployeeService.SaveEmployeeResponse> SaveEmployeeAsync(WebClientEmployeeService.EmployeeService.EmployeeInfo request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EmployeeRequestObject", WrapperNamespace="http://mycompany.com/Employee", IsWrapped=true)]
    public partial class EmployeeRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://mycompany.com/Employee")]
        public string LicenseKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mycompany.com/Employee", Order=0)]
        public int EmployeeId;
        
        public EmployeeRequest() {
        }
        
        public EmployeeRequest(string LicenseKey, int EmployeeId) {
            this.LicenseKey = LicenseKey;
            this.EmployeeId = EmployeeId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EmployeeInfoObject", WrapperNamespace="http://mycompany.com/Employee", IsWrapped=true)]
    public partial class EmployeeInfo {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mycompany.com/Employee", Order=0)]
        public int Id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mycompany.com/Employee", Order=1)]
        public string Name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mycompany.com/Employee", Order=2)]
        public string Gender;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mycompany.com/Employee", Order=3)]
        public System.DateTime DOB;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mycompany.com/Employee", Order=4)]
        public WebClientEmployeeService.EmployeeService.EmployeeType typeContract;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mycompany.com/Employee", Order=5)]
        public int AnnualSalary;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mycompany.com/Employee", Order=6)]
        public int HourlyPay;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://mycompany.com/Employee", Order=7)]
        public int HoursWorked;
        
        public EmployeeInfo() {
        }
        
        public EmployeeInfo(int Id, string Name, string Gender, System.DateTime DOB, WebClientEmployeeService.EmployeeService.EmployeeType typeContract, int AnnualSalary, int HourlyPay, int HoursWorked) {
            this.Id = Id;
            this.Name = Name;
            this.Gender = Gender;
            this.DOB = DOB;
            this.typeContract = typeContract;
            this.AnnualSalary = AnnualSalary;
            this.HourlyPay = HourlyPay;
            this.HoursWorked = HoursWorked;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveEmployeeResponse {
        
        public SaveEmployeeResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : WebClientEmployeeService.EmployeeService.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<WebClientEmployeeService.EmployeeService.IEmployeeService>, WebClientEmployeeService.EmployeeService.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClientEmployeeService.EmployeeService.EmployeeInfo WebClientEmployeeService.EmployeeService.IEmployeeService.GetEmployee(WebClientEmployeeService.EmployeeService.EmployeeRequest request) {
            return base.Channel.GetEmployee(request);
        }
        
        public int GetEmployee(string LicenseKey, int EmployeeId, out string Name, out string Gender, out System.DateTime DOB, out WebClientEmployeeService.EmployeeService.EmployeeType typeContract, out int AnnualSalary, out int HourlyPay, out int HoursWorked) {
            WebClientEmployeeService.EmployeeService.EmployeeRequest inValue = new WebClientEmployeeService.EmployeeService.EmployeeRequest();
            inValue.LicenseKey = LicenseKey;
            inValue.EmployeeId = EmployeeId;
            WebClientEmployeeService.EmployeeService.EmployeeInfo retVal = ((WebClientEmployeeService.EmployeeService.IEmployeeService)(this)).GetEmployee(inValue);
            Name = retVal.Name;
            Gender = retVal.Gender;
            DOB = retVal.DOB;
            typeContract = retVal.typeContract;
            AnnualSalary = retVal.AnnualSalary;
            HourlyPay = retVal.HourlyPay;
            HoursWorked = retVal.HoursWorked;
            return retVal.Id;
        }
        
        public System.Threading.Tasks.Task<WebClientEmployeeService.EmployeeService.EmployeeInfo> GetEmployeeAsync(WebClientEmployeeService.EmployeeService.EmployeeRequest request) {
            return base.Channel.GetEmployeeAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClientEmployeeService.EmployeeService.SaveEmployeeResponse WebClientEmployeeService.EmployeeService.IEmployeeService.SaveEmployee(WebClientEmployeeService.EmployeeService.EmployeeInfo request) {
            return base.Channel.SaveEmployee(request);
        }
        
        public void SaveEmployee(int Id, string Name, string Gender, System.DateTime DOB, WebClientEmployeeService.EmployeeService.EmployeeType typeContract, int AnnualSalary, int HourlyPay, int HoursWorked) {
            WebClientEmployeeService.EmployeeService.EmployeeInfo inValue = new WebClientEmployeeService.EmployeeService.EmployeeInfo();
            inValue.Id = Id;
            inValue.Name = Name;
            inValue.Gender = Gender;
            inValue.DOB = DOB;
            inValue.typeContract = typeContract;
            inValue.AnnualSalary = AnnualSalary;
            inValue.HourlyPay = HourlyPay;
            inValue.HoursWorked = HoursWorked;
            WebClientEmployeeService.EmployeeService.SaveEmployeeResponse retVal = ((WebClientEmployeeService.EmployeeService.IEmployeeService)(this)).SaveEmployee(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClientEmployeeService.EmployeeService.SaveEmployeeResponse> WebClientEmployeeService.EmployeeService.IEmployeeService.SaveEmployeeAsync(WebClientEmployeeService.EmployeeService.EmployeeInfo request) {
            return base.Channel.SaveEmployeeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClientEmployeeService.EmployeeService.SaveEmployeeResponse> SaveEmployeeAsync(int Id, string Name, string Gender, System.DateTime DOB, WebClientEmployeeService.EmployeeService.EmployeeType typeContract, int AnnualSalary, int HourlyPay, int HoursWorked) {
            WebClientEmployeeService.EmployeeService.EmployeeInfo inValue = new WebClientEmployeeService.EmployeeService.EmployeeInfo();
            inValue.Id = Id;
            inValue.Name = Name;
            inValue.Gender = Gender;
            inValue.DOB = DOB;
            inValue.typeContract = typeContract;
            inValue.AnnualSalary = AnnualSalary;
            inValue.HourlyPay = HourlyPay;
            inValue.HoursWorked = HoursWorked;
            return ((WebClientEmployeeService.EmployeeService.IEmployeeService)(this)).SaveEmployeeAsync(inValue);
        }
    }
}
