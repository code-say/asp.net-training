using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Employee
    {
        double HRA;
        double TA;
        double DA;
        double PF;
        double TDS;
        double NetSalary;
        double GrossSalary;

        public int EmpNo { get; set; }
        public String EmpName { get; set; }
        public double Salary { get; set; }
        public Employee(int EmpNo, String EmpName, double Salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Salary = Salary;
        }

        public void CalculateGross()
        {
            if (Salary < 5000)
            {
                HRA = 0.1 * Salary;
                TA = 0.05 * Salary;
                DA = 0.15 * Salary;
            }
            else if (Salary < 10000)
            {
                HRA = 0.15 * Salary;
                TA = 0.1 * Salary;
                DA = 0.2 * Salary;
            }
            else if (Salary < 15000)
            {
                HRA = 0.2 * Salary;
                TA = 0.15 * Salary;
                DA = 0.25 * Salary;
            }
            else if (Salary < 20000)
            {
                HRA = 0.25 * Salary;
                TA = 0.2 * Salary;
                DA = 0.3 * Salary;
            }
            else
            {
                HRA = 0.3 * Salary;
                TA = 0.25 * Salary;
                DA = 0.35 * Salary;
            }

            GrossSalary = Salary + HRA + TA + DA;
            Console.WriteLine("Gross Salary : " + GrossSalary);
        }

        public void CalculateSalary()
        {
            PF = 0.1 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF - TDS);
            Console.WriteLine("Net Salary is : " + NetSalary);
        }
    }
}
