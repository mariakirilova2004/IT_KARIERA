using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakciq
{
    class ContractEmployee:BaseEmployee
    {
        public string employeeTask { get; set; }
        public string employeeDepartment { get; set; }
        public ContractEmployee(int employeeID, string employeeName, string employeeAddress, string employeeTask, string employeeDepartment) : base(employeeID, employeeName, employeeAddress)
        {
            this.employeeTask = employeeTask;
            this.employeeDepartment = employeeDepartment;
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Working on {employeeTask} in {employeeDepartment}.");
        }

        public override void CalculateSalary(int workingHours)
        {
            Console.WriteLine($"{250 + workingHours * 20}");
        }

        public override void GetDepartment()
        {
            Console.WriteLine($"{employeeDepartment}");
        }
    }
}
