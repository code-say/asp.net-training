using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // ADO.Net classes for SQL Server
using System.Data;

namespace Connect_Employee
{
    class Delete
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter EmpId: ");
            int _id = int.Parse(Console.ReadLine());


            ///connection string
            string cs = @"server = DESKTOP-TECH2LM\SQLEXPRESS;   
                          database = employee_detail;
                          Integrated Security=True;
                          MultipleActiveResultSets=True;
                          user id=;
                          Password=";



            SqlConnection con = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("select * from tbl_empdetail;", con);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "delete from tbl_empdetail where empid=@empid";
            cmd.Parameters.AddWithValue("@empid", _id);

            con.Open();
            int _rows = cmd.ExecuteNonQuery();
            con.Close();


            if (_rows > 0)
            {
                Console.WriteLine($"{_rows} Row(s) Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Failed to Delete/Invalid empId!");
            }

            Console.ReadKey();
        }

    }
}
