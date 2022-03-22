using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // ADO.Net classes for SQL Server
using System.Data;
using System.Configuration;

namespace Connect_Employee
{
    class Insert
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter EmpId: ");
            int _id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter EmpName:");
            string _name = Console.ReadLine();

            Console.WriteLine("Enter salary:");
            int _salary = int.Parse(Console.ReadLine());

            ///connection string
            //string cs = @"server = DESKTOP-TECH2LM\SQLEXPRESS;   
            //              database = employee_detail;
            //              Integrated Security=True;
            //              MultipleActiveResultSets=True;
            //              user id=;
            //              Password=";


            string cs = ConfigurationManager.ConnectionStrings["Connect_Employee"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            
            SqlCommand cmd = new SqlCommand("select * from tbl_empdetail;", con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "insert into tbl_empdetail(empid,empname,salary)values(@empid,@empname,@salary)";
            cmd.Parameters.AddWithValue("@empid", _id);
            cmd.Parameters.AddWithValue("@empname", _name);
            cmd.Parameters.AddWithValue("@salary", _salary);


            con.Open();
            int _rows=cmd.ExecuteNonQuery();
            con.Close();


            if(_rows>0)
            {
                Console.WriteLine("Inserted Successfully!");
            }
            else
            {
                Console.WriteLine("Failed to Insert!");
            }

            Console.ReadKey();
        }
       
    }
}

