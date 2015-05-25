using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using _05EmployeeService;

namespace EmployeeServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(EmployeeService)))
            {
                host.Open();
                Console.WriteLine("Host started at " + DateTime.Now.ToString() );
                Console.ReadLine();
            }
        }
    }
}
