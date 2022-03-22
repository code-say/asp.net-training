using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentInheritenceDemo
{
    public delegate void displayAll();
    public class Employee
    {
        double HRA;
        double TA;
        double DA;
        double PF;
        double TDS;

        protected double NetSalary;
        protected double GrossSalary;

        public int EmpNo { get; set; }
        public String EmpName { get; set; }
        public double Salary { get; set; }

        public Employee(int EmpNo, String EmpName, double Salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Salary = Salary;
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

        }

        public virtual void CalculateGross()
        {
            GrossSalary = Salary + HRA + TA + DA;
            Console.WriteLine("Gross Salary of Employee: " + GrossSalary);
        }
        public virtual void CalculateSalary()
        {
            PF = 0.1 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF - TDS);
            Console.WriteLine("Net Salary of Employee : " + NetSalary);
        }

        public virtual void displayData()
        {
            Console.WriteLine("Employee Number :" + EmpNo);
            Console.WriteLine("Employee Name :" + EmpName);
            Console.WriteLine("Salary :" + Salary);
        }


    }

    class Manager : Employee
    {
        private double PA;
        private double FA;
        private double OA;
        public Manager(int EmpNo, String EmpName, double Salary) : base(EmpNo, EmpName, Salary)
        {
            PA = 0.8 * Salary;
            FA = 0.13 * Salary;
            OA = 0.03 * Salary;
        }

        public override void CalculateGross()
        {
            GrossSalary = PA + FA + OA;

        }

        public override void CalculateSalary()
        {
            NetSalary = GrossSalary + Salary;

        }



        public override void displayData()
        {
            Console.WriteLine("Employee Number :" + EmpNo);
            Console.WriteLine("Employee Name :" + EmpName);
            Console.WriteLine("Salary :" + Salary);
            Console.WriteLine("Manager Gross Salary is :" + GrossSalary);
            Console.WriteLine("Net Salary of Manager : " + NetSalary);
        }

    }

    class MarketingExecutive : Employee
    {
        public double km;
        double tourAllowance;
        int TelAllowance = 1000;
        public MarketingExecutive(int EmpNo, String EmpName, double Salary) : base(EmpNo, EmpName, Salary) { }
        public override void CalculateGross()
        {
            tourAllowance = km * 5;
            GrossSalary = tourAllowance + TelAllowance;

        }

        public override void CalculateSalary()
        {
            NetSalary = GrossSalary + Salary;

        }


        public override void displayData()
        {
            Console.WriteLine("Employee Number :" + EmpNo);
            Console.WriteLine("Employee Name :" + EmpName);
            Console.WriteLine("Salary :" + Salary);
            Console.WriteLine("MarketingExecutive  Gross Salary is :" + GrossSalary);
            Console.WriteLine("Net Salary of MarketingExecutive  : " + NetSalary);

        }


    }


    internal class Program
    {
        static void Main()
        {
            Manager M = new Manager(1, "Rahul", 2500);
            M.CalculateGross();
            M.CalculateSalary();
            MarketingExecutive M1 = new MarketingExecutive(2, "Sayan", 25000);
            M1.km = 25;
            M1.CalculateGross();
            M1.CalculateSalary();
            displayAll d1 = new displayAll(M.displayData);
            d1 += M1.displayData;
            d1();
            Console.ReadKey();
        }
    }
}
