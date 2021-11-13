using Final_Project.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DataAccessLayer
{
    class EmployeeDataAccess
    {
        DataAccess dataAccess;
        public EmployeeDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public int AddEmployees(Employee employees)
        {
            string sql = "INSERT INTO Employee(Name,Joining_date,DOB,Salary,Contact,Address,Designation,Branch_id,Blood_Group,User_Id) VALUES('" + employees.Name + "','" + employees.Joining_date + "','" + employees.DOB + "','" + employees.Salary + "','" + employees.Contact + "','" + employees.Address + "','" + employees.Designation + "','" + employees.Branch_id + "','" + employees.Blood_Group + "','"+employees.UserId+"')";
            return this.dataAccess.ExecuteQuery(sql);
        }

        public Employee GetEmployee(int id)
        {
            string sql = "SELECT * FROM Employee where User_Id ="+id;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            Employee en = new Employee();
            en.Id = (int)reader["Id"];
            en.Name = reader["Name"].ToString();
            en.Joining_date = reader["Joining_date"].ToString();
            en.Salary = float.Parse(reader["Salary"].ToString());
            en.DOB = reader["DOB"].ToString();
            en.Contact = reader["Contact"].ToString();
            en.Address = reader["Address"].ToString();
            en.Designation = (int)reader["Designation"];
            en.Branch_id = (int)reader["Branch_id"];
            en.Blood_Group = reader["Blood_Group"].ToString();
            en.UserId = (int)reader["User_Id"];
            return en;
        }

        public int getBranchId(int id)
        {
            string sql = "SELECT Branch_id FROM Employee where User_Id ="+id;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            return (int)reader["Branch_id"];
        }
        public List<Employee> GellAllEmployessData()
        {
            string sql = "SELECT * FROM Employee";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Employee> employee = new List<Employee>();
            while (reader.Read())
            {
                Employee en = new Employee();
                en.Id = (int)reader["Id"];
                en.Name = reader["Name"].ToString();
                en.Joining_date = reader["Joining_date"].ToString();
                en.Salary = float.Parse(reader["Salary"].ToString());
                en.DOB = reader["DOB"].ToString();
                en.Contact = reader["Contact"].ToString();
                en.Address = reader["Address"].ToString();
                en.Designation = (int)reader["Designation"];
                en.Branch_id = (int)reader["Branch_id"];
                en.Blood_Group = reader["Blood_Group"].ToString();
                en.UserId = (int)reader["User_Id"];
                employee.Add(en);

            }
            return employee;

        }

        public int DeleteEmployee(int id)
        {
            string sql = "DELETE FROM Employee WHERE User_Id =" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateEmployeeName(Employee en)
        {
            string sql = "UPDATE Employee SET Name='" + en.Name + "' WHERE Id=" + en.Id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int Update(Employee en)
        {
            string sql = "UPDATE Employee SET Salary='" + en.Salary + "',Designation  ='"+en.Designation+ "', Branch_id = '"+en.Branch_id+"', Bonus ='"+en.Bonus+"' WHERE User_Id=" + en.UserId;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateEmployeeSalary(Employee en)
        {
            string sql = "UPDATE Employee SET Salary ='" + en.Salary + "' WHERE Id=" + en.Id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateEmployeeContact(Employee en)
        {
            string sql = "UPDATE Employee SET Contact='" + en.Contact + "' WHERE Id=" + en.Id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateEmployeeAddress(Employee en)
        {
            string sql = "UPDATE Employee SET Address='" + en.Address + "' WHERE Id=" + en.Id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

    }
}

