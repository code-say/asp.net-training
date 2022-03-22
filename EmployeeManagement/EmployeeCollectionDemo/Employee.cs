using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCollectionDemo
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public int EmpSal;
        public Employee(int eid, string ename, int esal)
        {
            this.EmpId = eid;
            this.EmpName = ename;
            this.EmpSal = esal;
        }
        public override string ToString() =>
           $"{EmpId}: {EmpName} -> {EmpSal}";

    }
}
