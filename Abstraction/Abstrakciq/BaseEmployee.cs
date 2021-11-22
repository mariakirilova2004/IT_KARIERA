using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakciq
{
    abstract class BaseEmployee
    {
        public virtual int employeeID { get; set; }
        public virtual string employeeName { get; set; }
        public virtual string employeeAddress { get; set; }
        public BaseEmployee(int employeeID, string employeeName, string employeeAddress)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.employeeAddress = employeeAddress;
        }

        public void Show()
        {
            Console.WriteLine($"This is {this.employeeID} - {this.employeeName} living on {this.employeeAddress}.");
        }

        public abstract void CalculateSalary(int workingHours);
        public abstract void GetDepartment();
    }
}
