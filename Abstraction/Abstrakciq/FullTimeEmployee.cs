using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakciq
{
    class FullTimeEmployee:BaseEmployee
    {
        public string employeePosition { get; set; }
        public string employeeDepartment { get; set; }
        public FullTimeEmployee(int employeeID, string employeeName, string employeeAddress,string employeePosition,string employeeDepartment):base(employeeID, employeeName, employeeAddress)
        {
            this.employeePosition = employeePosition;
            this.employeeDepartment = employeeDepartment;
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Working as {employeePosition} in {employeeDepartment}.");
        }
        public override void CalculateSalary(int workingHours)
        {
            Console.WriteLine($"{250 + workingHours * 10.80}");
        }

        public override void GetDepartment()
        {
            Console.WriteLine($"{employeeDepartment}");
        }
    }
}
