using Final_Project.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DataAccessLayer
{
    class Employee_ProblemDataAccess
    {
        DataAccess dataAccess;
        public Employee_ProblemDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Employee_Problem> GetEmployeeProblemData()
        {
            string sql = "SELECT * FROM Employee_Problem";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Employee_Problem> employee_Problems = new List<Employee_Problem>();
            while (reader.Read())
            {
                Employee_Problem employee_Problem = new Employee_Problem();
                employee_Problem.Problem = reader["Problem"].ToString();
                employee_Problem.User_id = (int)reader["User_id"];
                employee_Problem.Branch_id = (int)reader["Branch_id"];
                employee_Problems.Add(employee_Problem);
            }
            return employee_Problems;
        }

        public Employee_Problem GetBranch()
        {
            string sql = "SELECT * FROM Employee_Problem";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            Employee_Problem employee_Problem = new Employee_Problem();
            employee_Problem.Problem = reader["Problem"].ToString();
            employee_Problem.User_id = (int)reader["User_id"];
            employee_Problem.Branch_id = (int)reader["Branch_id"];
            return employee_Problem;
        }
        public int InsertProblem(Employee_Problem employee_Problem)
        {
            string sql = "INSERT INTO Employee_Problem(Problem,User_id,Branch_id) VALUES('" + employee_Problem.Problem + "','" + employee_Problem.User_id + "'," + employee_Problem.Branch_id + ")";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int DeleteProblem(int id)
        {
            string sql = "DELETE FROM Employee_Problem  WHERE User_id=" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int UpdateProblem(Employee_Problem employee_Problem)
        {
            string sql = "UPDATE Employee_Problem SET Problem='" + employee_Problem.Problem + "' WHERE User_id='" + employee_Problem.User_id + "'";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }


    }
}
