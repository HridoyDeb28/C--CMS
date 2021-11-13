using Final_Project.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DataAccessLayer
{
    class BranchDataAccess
    {
         DataAccess dataAccess;
        public BranchDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public List<Branch> GetAllBranch()
        {
            string sql = "SELECT * FROM Branch";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<Branch> branches = new List<Branch>();
            while (reader.Read())
            {
                Branch branch = new Branch();
                branch.Id = (int)reader["Id"];
                branch.Branch_Name = reader["Branch_Name"].ToString();
                branch.Address = reader["Address"].ToString();
                branches.Add(branch);
            }
            return branches;
        }
        
        public int InsertBranch(Branch branch)
        {
            string sql = "INSERT INTO Branch(Branch_Name,Address) VALUES('" + branch.Branch_Name + "','" + branch.Address+ "')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int DeleteBranch(int id)
        {
            string sql = "DELETE FROM Branch WHERE Id=" + id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int UpdateBranch(Branch branchName)
        {
            string sql = "UPDATE Branch SET Branch_Name='" + branchName.Branch_Name + "' WHERE Address='" + branchName.Address + "'";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }



    }
}
